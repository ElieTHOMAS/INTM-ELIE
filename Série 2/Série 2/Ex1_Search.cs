using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Search
    {

        public static int LinearSearch(int[] tableau, int valeur)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                if (tableau[i] == valeur)
                {
                    return i + 1;
                }
            }

            return -1;
        }
        //Pire cas: nombre de lectures = length -1
        public static int BinarySearch(int[] tableau, int valeur)
        {
            int i = tableau.Length / 2;
            int j = i / 2;

            while (tableau[i - 1] != valeur)
            {
                if (tableau[i - 1] > valeur)
                {
                    i = i - j;
                }

                else if (tableau[i - 1] < valeur)
                {
                    i = i + j;
                }
                else

                {
                    return -1;
                }

            }
            return i;
        }// pire des cas, nombre de lectures = (n-1)/2
    }
}
