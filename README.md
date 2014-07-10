# VirtualPlaybackKeys

## The problem
My new [Sculpt Ergonomic Keyboard](http://www.microsoft.com/hardware/en-us/b/sculpt-ergonomic-keyboard-for-business) is really nice, but there's one feature that it doesn't have that I miss: dedicated media playback (play / pause, next track, previous track) keys.  

## The solution
Add global hotkeys that emulate the media playback keys. 

The mapping is:

* `Windows`+`Shift`+`{`: previous track
* `Windows`+`Shift`+`}`: next track
* `Windows`+`Shift`+`|`: play / pause

The emulation should work with any program that supports the physical media playback keys (eg. Spotify, iTunes, Media Player, VLC). Note that some programs may only work if they're in the foreground. 

## Installation and use
If you'd like this to start up every time you log in, copy the .exe available from [the releases page](https://github.com/charleskorn/VirtualPlaybackKeys/releases) into your Startup folder, which is usually something like `C:\Users\(your name)\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup`. (The easiest way to find your startup folder is to open `shell:startup` using Run.)

As long as the program is running, the hotkeys will work. There is no UI or notification area icon.

## Ideas for future improvements
* Configurable mapping for any hotkey to any key
* Tray icon and UI for configuring mappings

## Acknowledgements
* [Christian Liensberger](http://www.liensberger.it/web/blog/?p=207): global hotkey registration on Windows
* [pinvoke.net](http://pinvoke.net/): other Win32 method signatures

## License

The MIT License (MIT)

Copyright (c) 2014 Charles Korn.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

