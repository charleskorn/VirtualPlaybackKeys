using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace VirtualPlaybackKeys
{
    public partial class App : Application
    {
        private GlobalHotkeyManager hotkeyManager;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            hotkeyManager = new GlobalHotkeyManager();
        }

    }
}
