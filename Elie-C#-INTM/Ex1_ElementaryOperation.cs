using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class ElementaryOperations
    {//Opértions de base
        public static void BasicOperation(int a, int b, char c)
        {
            int res123;
     // Je fais un switch, en fonction de l'opérateur
            switch (c)
            {
                case '+' :
                    res123 = a + b;
                    Console.WriteLine(a + " " + c + " " + b + " = " + res123);
                break;
     // Soustraction
                case '-' :
                    res123 = a - b;
                    Console.WriteLine(a + " " + c + " " + b + " = " + res123);
                break;
     // division, avec un if pour le cas de la division par zero
                case '/' :
                    if (b != 0)
                    {
                        res123 = a / b;
                        Console.WriteLine(a + " " + c + " " + b + " = " + res123);
                    }
                    else
                     Console.WriteLine(a + " " + c + " " + b + " = " + "opération invalide"); 

                break;
     //Multiplication
                case '*' :
                    res123 = a * b;
                    Console.WriteLine(a + " " + c + " " + b + " = " + res123);

                break;
     // Si un autre caractère a été utilisé comme opératur
                default :
                
                Console.WriteLine(a + " " + c + " " + b + " = " + "opération invalide");
                break;
            }
           
        }
     //Division entière
        public static void IntegerDivision(int a, int b)

        {
            int q;
            int r;
           
     //If, pour gérer la division par 0       
            if (b == 0)
            { Console.WriteLine(a +" : " + b + " = Opération invalide" ); }

            else
     
            {
                q = a / b;
                r = a % b;     
                Console.WriteLine(a + " = "+ q + " * " + b + " + " + r);

            }
        }    
     //Calcul d'une puissance
        public static void Pow(int a, int b)
        {
            int puiss;

     //Cas d'une puissance négative
            if (b < 0)
            { Console.WriteLine(a + " ^ " + b + " = Opération invalide"); }

            else
            {
     //On va boucler en multipliant la variable a par elle même, b fois
                puiss = 1;
                int boucle = 0;
                while (boucle < b)
                {
                    puiss = puiss * a;
                    boucle++;
                }

             Console.WriteLine(a + " ^ " + b + " = " + puiss); 
            }
        }
    }
    

}
