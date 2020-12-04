# SymWin Changelog

Documenting changes made by Darren J. de Lima over the original project.

Spoiler: you can type your chosen key into the starting box, if you can't find it from the wacky names Windows uses

## Changes 4: 04-12-2020
- v0.3 release

Added:
- Add Help.md to release, with notes about ```Oem``` keys in the GUI, and how to start with Windows
- Every key that has a ```\``` or ```/``` should now have both on it by default (because I can never find the correct slashes when swapping between UK and US keyboards, and Windows needs backslash for paths, WWW needs forwardslash for websites)
- duplicated French quotes to comma ```,<``` and stop ```.>``` keys, because the glyphs look the same and OemQuotes is ```#~``` on my UK keyboard...
- ... hence why I also duplicated the tilde letters to OemQuotes (Sorry, Americans).

Removed:
- ~~Remove~~ Comment Numlock; it's bad practice to allow mapping to that (same reason Scroll Lock, Enter, Escape, Tab, Alt, Shift, AltGr, Ins, PrtScr, PgUp, PgDn, Home, End, Win should not be mapped to) 
- Commented Arrows (these are used for navigation, including for this program; use numpad 8246 for arrow glyphs) and Function keys (these are used for system functions, shouldn't be used for typing special chars)
- (exceptions are made for CapsLock and Space, even though these shouldn't be allowed, either)
- If there's enough demand, I'll uncomment them for v0.4 release 
- Earlier, I put an alternate regular P Paragraph symbol on P, as the non-shifted regular version. Turns out, Word etc. only use 1 inverse P as a paragraph symbol. Removed the alternate one from being a default.
- remove ```// { Key.IMEConvert, _sEmpty },``` as it doesn't work and isn't needed


## Changes 3: 03-12-2020 Evening/Night
- Key.OemOpenBrackets was there all along. 
- reorganization of keylist: group numpad keys, label as such (gotta find out how to rename the keys in the keylist) - tried to add @ ', didn't work
- Missing keys: numpad enter, @'
- divided keys into groups according to keyboard location within the code
Added weird keys and tested that they all work well :D
- added F1-F12, Numpad numbers, Numlock keys, empty (no idea what should go there)
- Numpad Add: equals
- Space: back/forward slashes, underscore, dash, interpunct (woulda put full stop/period there, but it looked too confusing
- Arrows: arrow symbols (also on Numpad 8246)
- - Numpad divide now has backslash, Numpad subtract now has underscore 

because that's where standard US keyboards show it:
- 3 now has #
- 2 now has @

This is not true: put different chars for upper and lower case all you want:
```
// Note: Don't try to put different characters for upper and lower case, otherwise you'll get: "Invalid letter definition, unequal lower and upper case sequence length or length 0."
```
- Bug: takes a long time to quit. RAM usage may have gone up???
- duped a bunch of symbols, degree, paragraph, typography, to top left key. Oem8 might be @??? (Research: No)
- bug: hash and @ don't show up on numbers 2 and 3 (this is due to settings files left behind in LocalAppData from previous tests)
- Section ** Research into keys swapping around between US and UK keyboards** moved to ```SymWin_Help.md```


## Changes 2: 02-12-2020 Evening/Night

### LetterMappings.cs

- typos (missing/extra commas)
- 2nd (Caps) cent symbol was missing
- ditched hebrew; too bizarre with cursor direction swapping
- new icon 1 (need new icon 2, as white line looks rubbish at 16px)
- ditched emojis, as they're not supported, even as Unicode codes.
- Duplicated umlaut letters to colon key
- Duplicated ^ circumflex letters to 6/^ key
- Added Romanian comma-accented letters ă ș ț (pre-1904 ĭ ŭ ĕ d̦ not included), duplicated to comma key
https://en.wikipedia.org/wiki/Romanian_alphabet
- Moved bullet point to Key.OemMinus (this is the minus/underscore key) from Key.Subtract, where I'd erroneously put it.


## Changes 1: 02-12-2020 Morning

### LetterMappings.cs
Checked that a bunch of symbols were present; added comments so that I can find them again when I forget they're there.

Missing: Key.OEMsomethingsomething, the @' (at symbol/apostrophe) key - I don't know what it's called. Help pls!

Added:
- V: ✅ as I use V for checkmarks
- X: ❌, moved '×' (multiply) to 2nd
- Moved bullet point ● from Key.OemComma to Key.Subtract (I usually use this key for bullet points)
- Moved ellipsis (triple dot) character from Key.OEMComma (what on earth was it doing there?) to Key.OemPeriod
- Key.OemTilde: duplicated ñ, ã, õ
- Missing ```Key.OemOpenBrackets``` (sad smiley, like ```Key.D9```)
- Missing ```Key.D6``` ( dagger/doubledagger †  ‡, reference symbol ※)
- Missing ```Key.D7``` (some of my favorite emojis)  and experimental Arabic "ﷺ" (sallallahu alaihi wasallam / Peace and blessings be upon him). Shifted, it's different emojis
- Missing Portuguese accents to A, O (ã, â,  ô, õ, ó)
- Experimental: Hebrew alphabet to end of respective keys (for Heb. letters that have multiple Latin equivalents: Gimel=G, Waw/Vav=W, Chet/Heth and He=H, Tet and Taw=T, Yod=J, Koph=K, Samech, Shin, Tsade=S, ( (WTF, whenever I paste a 2nd Hebrew char, it swaps the direction of my cursor?!). "Final" forms of letters are the shift/caps version. Diacritics and special letters omitted because I don't know Hebrew and can't be bothered to tinker further with my keyboard direction swapping. If they prove annoying, I'll remove Hebrew in favour of Hebrew letters as symbols, e.g. U+2135 and up (ℵℶℷℸ)
- O: Added oethel (œ , Œ ), rearranged so that hôpital (Fr.) comes first, oethel 2nd (The Queen's British English uses it everywhere; it's only fallen out of use because bloody keyboards don't have it)
- duplicated ÷ to ```[forward slash/question mark key]``` and ```5/%``` (not every keyboard has a Numpad divide key)
- ```[question mark/forward slash]```: Interrobang ‽
- P: Paragraph marker ⁋
- ```[4/currency]```: ¢ cent
- F: Phi Φ φ
- ```[8/asterisk]```: more asterisks ⁑ ⁂
- D: degrees symbol º
- P: Psi ψ Ψ (pressure)

Reference:
https://unicode-table.com/en/
https://en.wikipedia.org/wiki/List_of_Unicode_characters
https://en.wikipedia.org/wiki/Hebrew_alphabet


## Change 0: 02-12-2020 Evening
I discovered [Symwin](https://github.com/mjvh80/SymWin/) and decided to build it, since no binaries were available. It is amazing! Much more intuitive than Antibody Software's WizKey and much less RAM-hungry than [WinCompose]