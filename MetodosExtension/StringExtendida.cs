using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension
{
    public static class StringExtendida
    {
        public static int CantidadPalabras(this string estring)
        {
            string[] palabras;
            palabras = estring.Split(',', ' ');
            return palabras.Length;
        }

    }
}
