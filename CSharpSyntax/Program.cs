using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            const int mojeKonstanta = 4;
            int polomer = 6;
            //polomer = polomer + 1;
            //polomer += 1;
            Console.WriteLine("povodni polomer {0}", polomer);
            int novyPolomer = polomer++;

            Console.WriteLine("novy Polomer {0}", novyPolomer);

            int zaseNovyPolomer = ++polomer; /*operator++ jeden operand prefix  najskor zvysi o jednu a potom vrati postfix najskor premennu polomer a potom pripocita*/
            Console.WriteLine("zase novy Polomer {0}", zaseNovyPolomer);

            Console.ReadLine();

            int vysledek;

            switch (vysledek)
                break
            { }


            case: 2;
                Console.WriteLine("vysledok je 2"



//10-20 alebo 40-60 vykonaj nieco

            if((((vysledek >= 10 && vysledek <= 20) || (vysledek >= 40 && vysledek <= 60))) && (vysledek != 16))
            {
                Console.WriteLine("vysledek je v ocakavanem rozsahu");

            }
            

            
        }
    }
}

