using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Matrix
    {
        public static int[,] BuildingMatrix(int[] leftVector, int[] rightVector)
        {
            int[,] matrice1 = new int[leftVector.Length,rightVector.Length];
            
            for (int i = 0; i < leftVector.Length; i++)
            {
                for (int j = 0; j < rightVector.Length; j++)
                {
                    matrice1[i,j]=leftVector[i]* rightVector[j] ;    
                }
             
            }
            return matrice1;

        }

        //public static int[,] Addition(int[,] leftMatrix, int[,] rightMatrix)
        //{
        //    //TODO
        //    return new int[,];
        //}

        //public static int[,] Substraction(int[,] leftMatrix, int[,] rightMatrix)
        //{
        //    //TODO
        //    return new int[,];
        //}

        //public static int[,] Multiplication(int[,] leftMatrix, int[,] rightMatrix)
        //{
        //    //TODO
        //    return new int[,];
        //}

        public static void DisplayMatrix(int[,] matrix)
        {
            string s = string.Empty;
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                {
                    s += matrix[i,j].ToString().PadLeft(5) + " ";
                }
                s += Environment.NewLine;
            }
            Console.WriteLine(s);
        }
    }
}
