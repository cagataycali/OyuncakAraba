using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OyuncakAraba
{
    class ExtractInput
    {
        /**
        * Extract to integer from string object.
        */
        public int extractInput(string sayi)
        {
            /**
            * Default
            */
            int yanit = 0;

            /**
            * Stringimizin içerisinden integer değerleri ayıklayalım.
            */
            string resultString = Regex.Match(sayi, @"\d+").Value;

            /**
            * Call input validation
            */
            InputValidation inputValidate = new InputValidation();

            /**
            * Eğer gelen gerçekten integer ise
            */
            if (inputValidate.TryToInt32(resultString) == 1)
            {
                yanit = Int32.Parse(resultString);
            }

            // Return.
            return yanit;
        }

        public static bool checkMove(string directive)
        {
            String[] split = directive.Split('_');

            try
            {
                string test = split[1];
                return true;
            }
            catch
            {
               // Console.WriteLine("Oops! It didn't work.");
               // Console.WriteLine("The offending string was \"{0}\"", directive);
                return false;
            }

        }

        public static int getMove(string directive)
        {
            String[] split = directive.Split('_');

            return Harita.convert(split[1]);
        }
    }
}
