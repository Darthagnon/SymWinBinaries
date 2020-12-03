/*
 * © Marcus van Houdt 2014
 * Updated by Darren J. de Lima 2020
 */

// Note: Does not support Unicode emoji/emoticons "Too many characters in character literal". Unless there exists an ASCII counterpart???
// Note: Don't try to put different characters for upper and lower case, otherwise you'll get: "Invalid letter definition, unequal lower and upper case sequence length or length 0."
// Note: BEWARE of adding Hebrew/Arabic characters; "final" forms cannot be put as "Caps" version, and Hebrew swaps arrow key/cursor direction because Hebrew is a RTL script!!!

using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.Xml;

namespace SymWin
{
   public static class LetterMappings
   {
      private static readonly Tuple<Char[], Char[]> _sEmpty = Tuple.Create(new Char[0], new Char[0]);

      public static readonly Dictionary<Key, Tuple<Char[], Char[]>> KeysToSymbols = new Dictionary<Key, Tuple<Char[], Char[]>>
      {
         // Initial rough mapping for letters, not too much thought has gone into this yet.
         { Key.A, Tuple.Create(new[] { 'á', 'à', 'ã', 'â', 'ä', 'ă', 'å', 'α', 'æ' }, // Caesar
                               new[] { 'Á', 'À', 'Ã', 'Â', 'Ä', 'Ă', 'Å', 'Α', 'Æ' })},

         { Key.B, Tuple.Create(new[] { 'β' },
                               new[] { 'Β' })},

         { Key.C, Tuple.Create(new[] { 'ç', '©' }, // Copyright symbol
                               new[] { 'Ç', '©' })},

         { Key.D, Tuple.Create(new[] { 'º', 'δ' }, // Degree symbol, Delta
                               new[] { 'º', 'Δ' })},

         { Key.E, Tuple.Create(new[] { 'é', 'è', 'ë', 'ê', 'ε', 'ð', 'η' }, // Eth
                               new[] { 'É', 'È', 'Ë', 'Ê', 'Ε', 'Ð', 'Η' })},

         { Key.F, Tuple.Create(new[] { 'φ', 'ƒ' }, // Greek Phi
                               new[] { 'Φ', 'Ƒ' })},

         { Key.G, Tuple.Create(new[] { 'γ' }, // Greek Gamma
                               new[] { 'Γ' })},

         { Key.H, Tuple.Create(new[] { 'ħ' },
                               new[] { 'Ħ' })},

         { Key.I, Tuple.Create(new[] { 'í', 'ì', 'ï', 'î', 'ι' },
                               new[] { 'Í', 'Ì', 'Ï', 'Î', 'Ι' })},

         { Key.J, _sEmpty },

         { Key.L, Tuple.Create(new[] { 'λ', 'ל' },
                               new[] { 'Λ', 'ל' })},

         { Key.M, Tuple.Create(new[] { 'µ' },
                               new[] { 'Μ' })},

         { Key.K, Tuple.Create(new[] { 'κ' }, 
                               new[] { 'Κ' })},

         { Key.N, Tuple.Create(new[] { 'ñ', 'ν', 'ŋ' },
                               new[] { 'Ñ', 'Ν', 'Ŋ' })},

         { Key.O, Tuple.Create(new[] { 'ô', 'œ', 'ó', 'ò', 'ö', 'õ', 'ø', 'ω' }, // Omega, oethel
                               new[] { 'Ô', 'Œ', 'Ó', 'Ò', 'Ö', 'Õ', 'Ø', 'Ω' })},

         { Key.P, Tuple.Create(new[] { 'π', 'ψ', '⁋', '¶' },
                               new[] { 'Π', 'Ψ', '⁋', '¶' })},

         { Key.Q, _sEmpty },

         { Key.R, Tuple.Create(new[] { 'ρ', '®' }, // Registered symbol
                               new[] { 'Ρ', '®' })},

         { Key.S, Tuple.Create(new[] { 'ß', 'ș', 'š', 'σ', 'ς' }, 
                               new[] { 'ẞ', 'Ș', 'Š', 'Σ', 'Σ' })},

         { Key.T, Tuple.Create(new[] { 'θ', 'ț', 'τ', 'þ', '™' }, // Trademark symbol
                               new[] { 'Θ', 'Ț', 'τ', 'Þ', '™' })},

         { Key.U, Tuple.Create(new[] { 'ú', 'ù', 'ü', 'û' },
                               new[] { 'Ú', 'Ù', 'Ü', 'Û' })},

         { Key.V, Tuple.Create(new[] { '✅' }, // I use V for checkmarks
                               new[] { '✅' })},

         { Key.W, Tuple.Create(new[] { 'ẃ', 'ẁ', 'ẅ', 'ŵ' },
                               new[] { 'Ẃ', 'Ẁ', 'Ẅ', 'Ŵ' })},

         { Key.X, Tuple.Create(new[] { '❌', '×', 'Ξ', 'χ' }, // Multiply
                               new[] { '❌', '×', 'ξ', 'Χ' })},

         { Key.Y, Tuple.Create(new[] { 'ý', 'ỳ', 'ÿ', 'ŷ' },
                               new[] { 'Ý', 'Ỳ', 'Ÿ', 'Ŷ' })},

         { Key.Z, Tuple.Create(new[] { 'ζ' },
                               new[] { 'Ζ' })},

         // Numbers
         { Key.D0, Tuple.Create(new[] { '☺', '☻', '∞', 'ø' }, new[]  { '☺', '☻', '∞', 'Ø' })}, // Happy smiley
         { Key.D1, Tuple.Create(new[] { '¡', '‼', '¹' }, new[] { '¡', '‼', '¹' })},
         { Key.D2, Tuple.Create(new[] { '²', '½', '√' }, new[] { '²', '½', '√' })},
         { Key.D3, Tuple.Create(new[] { '⅓', '³', '§' }, new[] { '⅓', '³', '§' })},
         { Key.D4, Tuple.Create(new[] { '£', '¥', '$', '€', '¢', '¤', '¼' }, new[] { '£', '¥', '$', '€', '¢', '¤', '¼' })},
         { Key.D5, Tuple.Create(new[] { '‰', '⅕', '♫', '♪' }, new[] { '‰', '⅕', '♫', '♪' })},
         { Key.D6, Tuple.Create(new[] { 'â', 'ê', 'î', 'ô', 'û', 'ŵ', 'ŷ' },
                                new[] { 'Â', 'Ê', 'Î', 'Ô', 'Û', 'Ŵ', 'Ŷ' })}, // Omitted Key 6/^, Duplicate circumflex letters
         { Key.D7, Tuple.Create(new[] { '′', '″', '†', '‡', '※', '♂' }, new[] { '′', '″', '†', '‡', '※', '♀' })}, // Omitted Key 7, Prime/doubleprime=inches/feet, typography, Male/Female
         { Key.D8, Tuple.Create(new[] { '⁑', '⁂', '★', '✼', '❀' }, new[] { '⁑', '⁂', '★', '✼', '❀' })},
         { Key.D9, Tuple.Create(new[] { '☹' }, new[] { '☹' })}, // Sad smiley
         
        //{ Key.OemOpenBrackets,  _sEmpty }, // Causes crashes because it doesn't exist
         { Key.OemCloseBrackets, Tuple.Create(new[] { '☺' }, new[] { '☺' })}, // Corrected to Happy Smiley U+263A
         { Key.Divide, Tuple.Create(new[]  { '÷' }, new[]  { '÷' })},
         { Key.OemQuotes, Tuple.Create(new[] { '«', '»'}, new[] { '«', '»'})},
         { Key.OemComma, Tuple.Create(new[]  { '∙', '≤', 'ș', 'ț' },
                                      new[]  { '∙', '≤', 'Ș', 'Ț' })}, // Catalan interpunct, Romanian comma-accents
         { Key.OemPeriod,  Tuple.Create(new[] { '…', '≥' }, new[] { '…', '≥' })},
         { Key.OemPlus,   Tuple.Create(new[] { '≈', '≠', '±' }, new[] { '≈', '≠', '±' })},

         { Key.Decimal, _sEmpty },
         { Key.Multiply, Tuple.Create(new[] { '×' }, new[] { '×' })},
         { Key.OemOpenBrackets, _sEmpty }, // = Oem4
         { Key.Oem8, _sEmpty },
         { Key.OemQuestion, Tuple.Create(new[] { '¿', '÷', '‽' }, new[] { '¿', '÷', '‽' })}, // Spanish inverse question mark
         { Key.OemBackslash, _sEmpty }, // Equals 102
         { Key.OemMinus, Tuple.Create(new[] { '●' }, new[] { '●' })}, // I use "-" for bullets
         { Key.OemPipe, Tuple.Create(new[] { '¦' }, new[] { '¦' }) },
         { Key.OemSemicolon, Tuple.Create(new[] { 'ä', 'ë', 'ï', 'ö', 'ü', 'ẅ', 'ÿ', },
                                          new[] { 'Ä', 'Ë', 'Ï', 'Ö', 'Ü', 'Ẅ', 'Ÿ', }) }, // = Oem1 = Oem102, Duplicate umlaut letters
         { Key.OemTilde, Tuple.Create(new[] { 'ã', 'ñ', 'õ' },
                                      new[] { 'Ã', 'Ñ', 'Õ' })}, // Duplicate tilde letters
         { Key.Subtract, _sEmpty },
      };

      public static void UpdateKey(Key key, Char[] lowerCase, Char[] upperCase)
      {
         if (lowerCase.Length != upperCase.Length) throw new ArgumentException("lower and upper case letter arrays must be of equal length");
         var pair = Tuple.Create(lowerCase, upperCase);
         KeysToSymbols[key] = pair;

         if (lowerCase.Length > 0)
            KeyToWindowMap[key] = new LetterSelector(key, pair);

         _UpdateCustomKeyBindings();
      }

      public static Dictionary<Key, LetterSelector> KeyToWindowMap { get; private set; }

      /// <summary>
      /// Constructs a popup window for each of the letter mappings.
      /// </summary>
      public static void InitializeWindowsAndBindings()
      {
         // Let's check if we got custom definitions for key bindings.
         _LoadCustomKeyBindings();

         KeyToWindowMap = new Dictionary<Key, LetterSelector>();

         foreach (var kvp in KeysToSymbols)
         {
            if (kvp.Value.Item1.Length > 0)
               KeyToWindowMap.Add(kvp.Key, new LetterSelector(kvp.Key, kvp.Value)); ;
         }
      }

      private static void _LoadCustomKeyBindings()
      {
         var bindingsStr = Properties.Settings.Default.KeyBindings;
         if (String.IsNullOrEmpty(bindingsStr)) return;

         var bindings = new XmlDocument();
         bindings.LoadXml(bindingsStr);

         try
         {
            foreach (XmlElement binding in bindings.SelectNodes("/bindings/binding"))
            {
               var key = (Key)Enum.Parse(typeof(Key), binding.GetAttribute("key"));
               var lcase = binding.GetAttribute("lower-case").ToCharArray();
               var ucase = binding.GetAttribute("upper-case").ToCharArray();

               if (lcase.Length != ucase.Length || lcase.Length == 0)
                  continue;

               if (KeysToSymbols.ContainsKey(key))
                  KeysToSymbols[key] = Tuple.Create(lcase, ucase);
            }
         }
         catch
         {
            return;
         }
      }

      private static void _UpdateCustomKeyBindings()
      {
         var doc = new XmlDocument();
         doc.LoadXml("<bindings />");

         foreach (var kvp in KeysToSymbols)
         {
            var binding = doc.CreateElement("binding");
            binding.SetAttribute("key", kvp.Key.ToString());
            binding.SetAttribute("lower-case", new String(kvp.Value.Item1));
            binding.SetAttribute("upper-case", new String(kvp.Value.Item2));
            doc.DocumentElement.AppendChild(binding);
         }

         Properties.Settings.Default.KeyBindings = doc.OuterXml;
         Properties.Settings.Default.Save();
      }

      public static void DeleteBindings()
      {
         Properties.Settings.Default.KeyBindings = "";
         Properties.Settings.Default.Save();
      }
   }
}
