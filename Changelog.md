# SymWin Changelog

Documenting changes made by Darren J. de Lima over the original project.

## Changes 3: 03-12-2020
- Key.OemOpenBrackets was there all along. reorganization of keylist.

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