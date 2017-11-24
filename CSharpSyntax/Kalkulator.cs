using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    class Kalkulator
    // dve a tri cisla a stringy a+b, a+b+c, spocitanie stringov a vrati int
    {
        public int Secti(int a, int b)
        {
            return a + b;
        }
        public int Secti(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Secti(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }
    }
}