using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{

    //Question 1a: 2j-1 blocs sur la ligne J; 2a: 2N-1 blocs à la base
    //Question 2a: N = position du sommet de la pyramide; 2b: gauche: n-j; droite:N=j

    public static class Pyramid
    {
        /// <summary>
        /// Fonction de construction d'une pyramide
        /// </summary>
        /// <param name="n">n représente le nombre d'étages de la pyramide</param>
        /// <param name="isSmooth"> représente la texture de la pyramide </param>
        public static void PyramidConstruction(int n, bool isSmooth)
        {
            
            for (int j = 1; j <= n; j++)

            {
                for (int t = 1; t <= n*2-1 ; t++)
                {
                    if (t >= n - j + 1  && t <= n + j - 1 )
                    {
                        if (j % 2 == 0 && !isSmooth)
                        {
                            Console.Write("-");
                        } 
                        else
                        { Console.Write("+"); }
                    }
                     
                    else
                        Console.Write(" ");
                }
                Console.WriteLine(" ");

            }       
         

        }
    }
}
