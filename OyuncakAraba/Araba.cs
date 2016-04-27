using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyuncakAraba
{
    class Araba
    {
        protected static int x;
        protected static int y;
        protected static bool marked = false;
        protected static int rotate = 0;//0 right 1 down 2 left 3 up
        public static void setCarBrush(bool state)
        {
            marked = state;
        }

        public static void setCarRotate(int direction)
        {
            Araba.rotate += direction ;
            Araba.rotate %= 4;
            if (Araba.rotate < 0)
                Araba.rotate = 3;
        }

        public static void setMove(int step)
        {
            for (int i = 0; i < step; i++)
            {
                switch(rotate)
                {
                    case 0:
                        Araba.move(0, 1);
                    break;
                    case 1:
                        Araba.move(-1, 0);
                    break;
                    case 2:
                        Araba.move(0, -1);
                    break;
                    case 3:
                        Araba.move(1, 0);
                    break;
                }
                
            }
           
        }

        public static void move(int x , int y)
        {
            if (marked)
            {
                Harita.mark(Araba.x, Araba.y);
            }
            int i_temp = (Araba.x + x) % Harita.getSize();
            if(i_temp < 0)
            {
                i_temp = Harita.getSize() - 1;
            }
            Araba.x = i_temp;

            i_temp = (Araba.y + y) % Harita.getSize();
            if (i_temp < 0)
            {
                i_temp = Harita.getSize() - 1;
            }
            Araba.y = i_temp;

            

        }
            
       
    }
}
