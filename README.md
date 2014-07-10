# VirtualPlaybackKeys

## The problem
My new [Sculpt Ergonomic Keyboard](http://www.microsoft.com/hardware/en-us/b/sculpt-ergonomic-keyboard-for-business) is really nice, but there's one feature that it doesn't have that I miss: dedicated media playback (play / pause, next track, previous track) keys.  

## The solution
Add global hotkeys that emulate the media playback keys. 

The mapping is:

* `Windows`+`Shift`+`{`: previous track
* `Windows`+`Shift`+`}`: next track
* `Windows`+`Shift`+`|`: play / pause

## How to use
If you'd like this to start up every time you log in, copy the .exe available from [the releases page](https://github.com/charleskorn/VirtualPlaybackKeys/releases) into your Startup folder, which is usually something like `C:\Users\(your name)\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup`. (The easiest way to find your startup folder is to open `shell:startup` using Run.)

## Acknowledgements
* [Christian Liensberger](http://www.liensberger.it/web/blog/?p=207): global hotkey registration on Windows
* [pinvoke.net](http://pinvoke.net/): other Win32 method signatures