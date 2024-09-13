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

        public static int BinarySearch(int[] tableau, int valeur)
        {
            int i = tableau.Length / 2;
            while (tableau[i] != valeur)
            { 
                if (tableau[i] < valeur)
                {
                    i == i / 2;
                }
                if (tableau[i] > valeur)
                {
                    i == i * (i/2);
                }
                
            }

            return -1;
        }
    }
}
