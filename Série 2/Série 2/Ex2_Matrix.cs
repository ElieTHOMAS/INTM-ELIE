using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Matrix
    {
        //public static int[,] BuildingMatrix(int[] leftVector, int[] rightVector)
        //{
        //    int[,] matrice1 = new int[leftVector.Length,rightVector.Length];

        //    for (int i = 0; i < leftVector.Length; i++)
        //    {
        //        for (int j = 0; j < rightVector.Length; j++)
        //        {
        //            matrice1[i,j]=leftVector[i]* rightVector[j] ;    
        //        }

        //    }
        //    return matrice1;
        public static int[][] BuildingMatrix(int[] leftVector, int[] rightVector)
        {
            int[][] matrice1 = new int[leftVector.Length][];

            for (int i = 0; i < leftVector.Length; i++)
            {
                matrice1[i] = new int[rightVector.Length];

                for (int j = 0; j < rightVector.Length; j++)
                {
                    matrice1[i][j] = leftVector[i] * rightVector[j];
                }

            }
            return matrice1;
        }

    public static int[][] Addition(int[][] leftMatrix, int[][] rightMatrix)
        {
            int[][] result = new int[leftMatrix.Length][];
            if (leftMatrix.Length == rightMatrix.Length)
            {
                for (int i = 0; i < leftMatrix.Length; i++)
                {
                    if (leftMatrix[i].Length == rightMatrix[i].Length)
                    {
                        result[i] = new int[leftMatrix[i].Length];

                        for (int j = 0;j < leftMatrix[i].Length; j++)
                        {
                            result[i][j] = leftMatrix[i][j] + rightMatrix[i][j];
                        }
                    }
                }
            }
            return (result);
        }

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

        public static void DisplayMatrix(int[][] matrix)
        {
            string s = string.Empty;
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    Console.WriteLine(matrix[i][j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
