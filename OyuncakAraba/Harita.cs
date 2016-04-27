using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OyuncakAraba
{
    class Harita
    {

        struct Map
        {
            public static int[,] dizi;
            public static int size;
        }

        public static void mark(int x ,int y )
        {
            Map.dizi[x, y] = 1;
        }


        

        /* Prepare map */
        public static int[,] PrepareMap(string boyut)
        {
            int dizi_boyutu = convert(boyut);

            /* Set size from struct of map. */
            Harita.setSize(dizi_boyutu);

            Map.dizi = prepareArray(dizi_boyutu);

            /* Fill array with 0 */
            fillArray();

            return Map.dizi;
        }

        /* Prepare array. */
        private static int[,] prepareArray(int dizi_boyutu)
        {
            return new int[dizi_boyutu, dizi_boyutu];
        }

        /* Fill array with 0 */
        private static void fillArray()
        {
            for (int i = 0; i < Map.size; i++)
            {
                for (int j = 0; j < Map.size; j++)
                {
                    Map.dizi[i, j] = 0;
                }
            }
        }

        /* Show map */
        public static void ShowMap()
        {

            for (int i = 0; i < Harita.getSize(); i++)
            {
                for (int j = 0; j < Harita.getSize(); j++)
                {
                    if (Map.dizi[i, j] == 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(Map.dizi[i, j] + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }

        /* String to int */
        public static int convert(string boyut)
        {
            /**
             * Input extraction
             */
            ExtractInput extract = new ExtractInput();

            /* Handle integers from string */
            int dizi_boyutu = extract.extractInput(boyut);

            /* Return size of array */
            return dizi_boyutu;
        }

        public static bool setSize(int size)
        {
            Harita.Map.size = size;
            return true;
        }

        public static int getSize()
        {
            return Harita.Map.size;
        }

        public static void splitDirectiveThenRun(string directives)
        {
            /*
                Split string from '+' (plus) char then check directive.
            */
            for (int i = 0; i < directives.Split('+').Length; i++)
            {
                /* Handle first loop */
                if (i == 0)
                {
                    /* Prepare map */
                    Harita.PrepareMap(directives.Split('+')[i]);
                }

                /* If is move directive */
                if (ExtractInput.checkMove(directives.Split('+')[i]))
                {
                    int move = ExtractInput.getMove(directives.Split('+')[i]);

                    Araba.setMove(move);

                    /* Debug point */
                    //Console.WriteLine(move);

                    continue;
                }
                else /* If ısn't moving action. */
                {

                    /* Command shortcut */
                    int command = Harita.convert(directives.Split('+')[i]);

                    /* Switch case skeleton */
                    switch (command)
                    {
                        case 1: /* Set brush up */
                            Araba.setCarBrush(true);
                            continue;
                        case 2: /* Set brush down */
                            Araba.setCarBrush(false);
                            continue;
                        case 3: /* Turn right */
                            Araba.setCarRotate(-1);
                            continue;
                        case 4: /* Turn left */
                            Araba.setCarRotate(1);
                            continue;
                        case 6: /* Jump */
                            Araba.setCarBrush(false); // Set brush up
                            Araba.setMove(3);
                            continue;
                        case 7: /* Reverse route 180* degree. */
                            Araba.setCarRotate(-1);
                            Araba.setCarRotate(-1);
                            continue;
                        case 8: /* Show map. */
                            Harita.ShowMap();
                            continue;
                        case 0: /* Exit. */
                            break;
                    }
                }
                /* Switch case skeleton */

            }
        }


    }
   
}
