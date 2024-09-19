using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percolation
{ 
    //QUESTIONS:
    //3-B: Dans le pire des cas, elle va ouvrir toutes les cases.
    //3-C: Une case pleine ne va jamais induire le remplissage de toutes les 
    //cases environnantes, qu'il soit dans un coin (2/3) ou au centre (4/8). 
    //De plus la présence de cases bloquées va empêcher certaines cases ouvertes d'être remplies.

     //Ce programme ne peut être testé en l'état.
    public class Percolation
    {
        private readonly bool[,] _open;
        private readonly bool[,] _full;
        private readonly int _size;
        private bool _percolate;

 
       
        public Percolation(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size), size, "Taille de la grille négative ou nulle.");
            }

            _open = new bool[size, size];
            _full = new bool[size, size];
            _size = size;
          
        }

//QUESTION 1a: IsOpen et IsFull

        public bool IsOpen(int i, int j)
     
        {   
            int coordonnees_O = Index(i,j);
            int[,] ouvert = new int[,];
            ouvert[i,j] = true;
            return _open[coordonnees_O];
        }


        private bool IsFull(int i, int j)
        {
            int coordonnees_F = Index(i,j);
            int[,] plein = new int[,];
            plein[i,j] = true;
            return _full[coordonnees_F];
                
        }

//Question 1b: Percolate

        public bool Percolate()
        {
         
            if (_percolate == false)

            {
                return -1; 
            } 
        }

//Question 2: CloseNeighbors

        private List<KeyValuePair<int, int>> CloseNeighbors(int i, int j)
        {
            int left = new int [2];
            int right = new int [2];
            int top  = new int [2];
            int bottom  = new int [2];
               if (hors_normes(i, j) && isOpen(i, j))
               {
               // left
                  if (j != 0)
                   {
                     left = { i,j-1};
                   }
                
               //right
                   if (j < size)
                   {
                     right = { i,j+1};
                   }

                //TOP
                   if (i != 0)
                   {
                     top = { i-1,j};
                   }
                //Bottom
                   if (i < size)
                   {
                     bottom = { i+1,j};
                   }
               }
            return null;
        }

        public void Open(int i, int j)
        {
        //Pas fait
        }

     //Pour accéder à l'index

        private int Index(int i, int j)
        {
            if (hors_normes(i, j))
            {
                return 
                    Console.WriteLine("problème coordonnées");
            }
            return (i - 1) * size+ (j - 1);
        }

        private bool hors_normes(int i, int j)
        {
            return i < 1 || j < 1 || i > size || j > size;
        }
    }
}
