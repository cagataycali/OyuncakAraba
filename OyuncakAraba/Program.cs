using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/*
    Çağatay ÇALI
    14253019
*/
namespace OyuncakAraba
{
    class Program
    {

        static void Main(string[] args)
        {
            /* Get directives */
            Console.WriteLine("Komutları giriniz");
            string directives = Console.ReadLine();

            /* Split directives then run commands. */
            Harita.splitDirectiveThenRun(directives);
        }
    }
}
