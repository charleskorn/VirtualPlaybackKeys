using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VirtualPlaybackKeys
{
    public class GlobalHotkeyManager : IDisposable
    {
        private KeyboardHook hook;

        // Key is the physical key the user presses (in conjunction with Windows+Shift),
        // value is the key that is then emulated.
        private Dictionary<Keys, Keys> mapping = new Dictionary<Keys, Keys>() { 
            {Keys.OemOpenBrackets, Keys.MediaPreviousTrack}, 
            {Keys.OemCloseBrackets, Keys.MediaNextTrack},
            {Keys.OemPipe, Keys.MediaPlayPause}
        };

        public GlobalHotkeyManager()
        {
            hook = new KeyboardHook();
            hook.KeyPressed += OnKeyPressed;

            foreach (var pair in mapping)
            {
                hook.RegisterHotKey(ModifierKeys.Win | ModifierKeys.Shift, pair.Key);
            }
        }

        private void OnKeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (!mapping.ContainsKey(e.Key))
            {
                // This should never happen.
                return;
            }

            Keys keyToEmulate = mapping[e.Key];

            // According to the documentation for the Keys enumeration, the Keys enum values are the same as the virtual key code, so
            // we can use it for MapVirtualKey and also for the INPUT struct below.
            ScanCodeShort scanCode = (ScanCodeShort)NativeMethods.MapVirtualKey((uint)keyToEmulate, MapVirtualKeyMapTypes.MAPVK_VK_TO_VSC);
            
            INPUT[] inputs = new[] {
                new INPUT {
                    type = INPUT_TYPE.INPUT_KEYBOARD,
                    U = new InputUnion {
                        ki = new KEYBDINPUT {
                            wScan = scanCode,
                            wVk = (VirtualKeyShort)keyToEmulate,
                        }
                    }
                },
                new INPUT {
                    type = INPUT_TYPE.INPUT_KEYBOARD,
                    U = new InputUnion {
                        ki = new KEYBDINPUT {
                            wScan = scanCode,
                            wVk = (VirtualKeyShort)keyToEmulate,
                            dwFlags = KEYEVENTF.KEYUP
                        }
                    }
                }
            };

            NativeMethods.SendInput((uint)inputs.Length, inputs, INPUT.Size);
        }

        #region IDisposable
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (hook != null)
                {
                    hook.Dispose();
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
