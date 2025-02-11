Currently unusable!
===========
dotSwitcher
===========
*If you're paranoid enough not to use [Punto switcher](http://punto.yandex.ru "closed source software")*

Simple keyboard layout switcher. As lightweight as you can easily ensure it doesn't contain any spyware, even if you're not a programming guru.

Changes in this fork
-----
I've added a functionality for autoreplacing user-defined combinations, since this is a killer-feature of Punto I couldn't find anywhere else.

Usage
-----
* Run
* Type a word anywhere
* Press Pause/Break until the word is typed in a right layout
* Profit!

Launching the program the second time shows the settings window, even if it is a hidden mode (no tray icon shown)

Improvements to be implemented
------------------------------
* Code refactoring and many comments
* Restoring clipboard contents after transformation of selected text 
* Build script
* Donation form :)

Credits
-------
GitHub icon by [Picons.me](https://picons.me/)

Known bugs
----------
If you experience erasing the word and retyping it again in the same layout (as did I, in skype), try to increase the switch delay in settings window (200 ms works for me).
If you know any workaround for [this](http://stackoverflow.com/questions/27720728/cant-send-wm-inputlangchangerequest-to-some-controls), your help would be much appreciated.
