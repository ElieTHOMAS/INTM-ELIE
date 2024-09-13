using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Factorial
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="n"> n contient la valeur rentrée par l'utilisateur</param>
    /// <returns></returns>
        public static int Factorial_(int n)
        {//On ne peut faire la factorielle que pour les nombres positifs. On va donc faire un retour -1 en cas de négatif, et 1 quand n = 0.
            int num1 = n;
            if (n > 0)

            {

                for (int i = n - 1; i > 0; i--)
                {
                    num1 = num1 * i;
                }
            
            return num1; 
            }

            if (n == 0)
                 return 1;

            else
                return -1;
        }
        // On fait la même factorielle, mais de façon récursive.
        public static int FactorialRecursive(int n)
        {
            
            if (n == 0)
            
                return 1;  
            
            if (n < 0)
                return -1;
            return n * FactorialRecursive(n - 1);
        }
    }
}
