using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using projetprogram;
using Microsoft.VisualBasic;

namespace projetprogram2
{
    internal class Output
    {
      
        //static string sortie = Environment.GetFolderPath("C:\\Users\\Formation\\source\\repos\\INTM-ELIE\\Comptestraités.csv");
        internal static void output(List<Transactions> liste_transaction)
        {
            using (StreamWriter outputfile = new StreamWriter(@"C:\Users\Formation\source\repos\INTM-ELIE\Comptestraites.csv"))
            {
                foreach (Transactions line in liste_transaction)
                {
                    outputfile.WriteLine(line.Id + ";" + line.Statut);
                }
            }

        }
    } 
}