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
    {
        public static void BasicOperation(int a, int b, char c)
        {
            int res123;
                        
            switch (c)
            {
                case '+' :
                    res123 = a + b;
                    Console.WriteLine(a + " " + c + " " + b + " = " + res123);
                break;

                case '-' :
                    res123 = a - b;
                    Console.WriteLine(a + " " + c + " " + b + " = " + res123);
                break;

                case '/' :
                    if (b != 0)
                    {
                        res123 = a / b;
                        Console.WriteLine(a + " " + c + " " + b + " = " + res123);
                    }
                    else
                     Console.WriteLine(a + " " + c + " " + b + " = " + "opération invalide"); 

                break;

                case '*' :
                    res123 = a * b;
                    Console.WriteLine(a + " " + c + " " + b + " = " + res123);

                break;

                default :
                
                Console.WriteLine(a + " " + c + " " + b + " = " + "opération invalide");
                break;
            }
           
        }

        public static void IntegerDivision(int a, int b)

        {
            int q;
           

            if (b == 0)
            { Console.WriteLine(a +" : " + b + " = Opération invalide" ); }

            else

            {
                q = a / b;
                    
                Console.WriteLine(a + " = " + b + "*" + q);

            }
        }    

        public static void Pow(int a, int b)
        {
            int puiss;
            if (b < 0)
            { Console.WriteLine(a + " ^ " + b + " = Opération invalide"); }

            else
            { 
                puiss = (a*a)*b;
             Console.WriteLine(a + " ^ " + b + " = " + puiss); 
            }
        }
    }
    

}
