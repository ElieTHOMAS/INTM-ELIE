using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class PrimeNumbers
    {
        static bool IsPrime(int valeur)
        {

            int racine2;

            if (valeur > 0)
            {
               double racine  = Math.Sqrt(valeur);
               racine2 = (int)racine;
               

                for (int i = racine2; i > 1; i--)
                {

                    if(valeur % i == 0)

                                   
                       return false;
                }

                return true;
            }
            else
            return false;
        }

        public static void DisplayPrimes()
        {
          
            int r2;
            int racine4;
           

             for (int i3 = 1; i3 < 101; i3 ++)
                 {
                    double racine3 = Math.Sqrt(i3);
                    racine4 = (int)racine3;

                    for (int i4 = racine4; i4 > 1; i4--)
                    {
                        r2 = i3 % i4;

                        if (r2 != 0 && i4 > 1 )
                        { Console.Write(i3 + " "); }

                    }
                  }
        
        }
    }
}
