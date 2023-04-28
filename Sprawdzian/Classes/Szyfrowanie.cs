using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sprawdzian.Classes
{
    internal static class Szyfrowanie
    {
        public static string ZaszyfrujCezar(string tekst, int klucz)
        {
            string final = "";

            for(int i = 0; i < tekst.Length; i++)
            {
                char c = tekst[i];
                char offset = char.IsUpper(c) ? 'A' : 'a';
                final += (char)((((c + klucz) - offset) % 26) + offset);
            }

            return final;
        }

        public static string OdszyfrujCezar(string szyfr, int klucz)
        {
            return ZaszyfrujCezar(szyfr, 26 - klucz);
        }
    }
}
