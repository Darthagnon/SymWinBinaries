# SymWin v0.3 Help

## How to quickly map custom keys

1. Start SymWin
2. Right-click on SymWin's tray icon >> Configure Symbols
3. 3 boxes appear in the GUI:

| Configure Key Bindings | | |
|-------------------- |-|-|
| [Dropdown with key list] | type lower case keys here | TYPE CAPS KEYS HERE |

- Tip: The key list dropdown is typeable. If you can't find your key in the list, type it, and it should appear. Some symbol/special keys don't show up with recognisable names, so type if in doubt.
- Tip: It is recommended to type lowercase and UPPERCASE letters in the same order for consistency, but you don't have to. You don't even need to type the same characters for upper and lower case, e.g. if you're typing a lot of symbols.
- General Unicode symbols are supported. Emojis are NOT SUPPORTED. 


## I don't like SymWin, what alternatives are there?
In order of how good they are:
1. **[WinCompose](http://wincompose.info/)**, a 100MB RAM fully-featured compose key for Windows: hold a hotkey, then type a letter followed by an accent, e.g. colon, and they'll be combined into accented letters or emojis. Takes some imagination and thought to use. Make sure to enable **Options** >> **Tweaks** >> **On invalid sequences** >> **Try to swap the two keys** to make it easier to use. It has no GUI while in use; refer to it's cheatsheet if confused. Still in slow, but active, development as of 12/2020.
2. **[Antibody Software's Wizkey](https://antibody-software.com/wizkey/)**, 2013 commercial abandonware that works well, is a bit ugly and can't be pirated yet (though you can run the trial forever using [NirSoft RunAsDate](https://www.nirsoft.net/utils/run_as_date.html))
3. **[CatchChar](https://www.softpedia.com/get/Office-tools/Other-Office-Tools/CatchChar.shtml)**, free abandonware that adds a hotkey to bring up a vertical context menu with special characters. Unfortunately, doesn't come with any presets, and is a pain to configure. ([Old Homepage](https://helpingthings.com/index.php/insert-unicode-characters), [New Homepage](https://whizfolders.com/addons.aspx))
4. **HoldKey[http://www.holdkey.eu/ ]**, commercial (with demo) software that works in a similar way to SymWin; a user has switched to SymWin in preference as HoldKey mappings cannot be customised.
5. **Microsoft Office's Insert Symbol option**, but it's only usable in Microsoft Office (other office software will have equivalents)
6. **Charmap.exe (Character Map)** comes with Windows, but it's rubbish
7. **[ExtraKeys](https://www.deeproot.co.uk/extrakeys.html)**, a commercial/demo Character Map on-screen keyboard. From screenshots, it was made for WinXP.
8. **[BabelMap](https://www.babelstone.co.uk/Software/BabelMap.html)**, yet another alternative FOSS Character Map
9. **[PopChar](https://www.ergonis.com/products/popcharwin/)**, commercial Character Map alternative
10. **[AllChars](http://allchars.zwolnet.com/)**, abandoned FOSS project similar in function to SymWin, but **DO NOT USE IT**. It is extremely outdated and will glitch out your PC; I tried.
11. **[Mac OS X](https://www.howtogeek.com/219834/how-to-enter-special-characters-in-os-x-in-two-keystrokes/)** has a popup window identical to SymWin when you hold a key, rather than typing ```aaaaaaaaaaaaaaaa``` like most other operating systems.

If you're on Windows 7/8/8.1 and you want an emoji picker, like Windows 10 has, I recommend [WinMoji](https://github.com/ryanSN/winmoji) (NB. it's a Chromium app, but there's very few alternatives) or [Jack Le's Emoji Keyboard 2.0](https://www.youtube.com/watch?v=Lwn0AYreSMw) (C#/.Net, but closed-source and kinda jank)


## How to start SymWin with Windows?
1. SymWin runs with Admin permissions, and so CANNOT be started automatically by making a shortcut ```SymWin.lnk``` to it in %AppData%\Microsoft\Windows\Start Menu\Programs\Startup\
2. Instead, press ```Win```+```R``` and type ```taskschd.msc``` to start Task Scheduler
3. Click on **Create Task** and enter the following details:
	- Name: SymWin Startup
	- Description: Start SymWin with Windows
	- Run with highest privileges (i.e. Admin)
	- Triggers: At Startup (Optional: Delay task for 30 seconds)
	- Actions: Start a program (Insert path of SymWin.exe)
	- Conditions and Settings: Untick all (Windows ticks some bizarre options here by default)
4. Click OK to save your task. SymWin will now automatically start with Windows.


## How demanding is SymWin?
- Disk space: approx. 128kB
- RAM: 14-30MB Private Working Set, 35-60MB Private Bytes
- CPU: 0% while idle, 0.05% CPU cycling through accent popup menu

## What is SymWin tested on?
- I believe it was originally programmed for a Swedish keyboard
- Intel Core i7-7700HQ, 16GB RAM, Win10 v1709, UK Keyboard
- Occasionally on my family's other PCs with mostly US keyboards (mappings switchable to UK mode) 
- I also grew up using the Swiss-French keyboard

## I mapped lots of custom keys and want to backup my settings. Where are they saved?
```
%LocalAppData%\Symwin\SymWin.exe_Url_L0ngStr1ng0fR4nd0mL3tters\1.0.0.0\user.config
```


## Research into keys swapping around between US and UK keyboards
**Bug:** Oem1, Oem3, Oem5, Oem6, Oem8 appear in the GUI rather than friendly names. They mean different things on different keyboards. I have tested on a UK keyboard, US keyboard, and US-mapped-to-UK keyboard.

M$ gives 2x keynames per key [here](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.keys?view=netframework-4.0); because this is really confusing, I'm only using the one that shows up in the SymWin GUI (this is not necessarily what it's programmed with). Note that ```Oem8``` is undocumented.

| GUI| US | UK | SymWin Defaults |
|-----|------|-----|-------------|
|Oem1 | OemSemicolon | OemSemicolon | ümläut accents |
|Oem8 | undocumented, nonexistent??? | Top leftest, ```acute `¬¦``` | ```¦, º, §, ¶``` typography, ```¦``` added so no more AltGr needed |
|Oem3 | Top leftest, OemTilde ```~ and ` acute``` | ```@'``` key, RHS | US default, tilde letters (copied to OemQuotes for UK keyboard) |
|OemQuotes | Single/double quotes RHS | OemTilde ```~#``` RHS| umlauts are already done, so duplicate tilde letters here for UK keyboards
|Oem5 | OemPipe | bottom leftest, OemPipe | Pipe has vertical line and backslash, so I added ```/ ¦ ¬```
|Oem6 |OemCloseBrackets (square/curly) | OemCloseBrackets (square/curly) | Sad smiley |
|OemBackslash | nonexistent??? Tested as not Backslash (OemPipe)| nonexistent??? Tested as not OemPipe | Added ```/```, though I don't know where it is. Backslash is on OemPipe key for US and UK keyboards |

## Contact Details
The original programmer, [Marcus van Houdt a.k.a mjvh80](https://github.com/mjvh80/SymWin) hasn't been on GitHub since 2018.

The current (12/2020) builder/maintainer is [Darren J. de Lima a.k.a. Darthagnon](https://github.com/Darthagnon/SymWinBinaries). I'm not much of a programmer, so pull requests/help is much appreciated.

Email: darren.delima@yahoo.co.uk
