using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using projetprogram;

namespace Projet_C__Elie_THOMAS
{
    internal class Output
    {
      
        static string sortie = Environment.GetFolderPath("C:\\Users\\Formation\\source\\repos\\INTM-ELIE");
        internal static void output(List<Comptes> liste_compte, List<Transactions> liste_transaction)
        {
            using (Streamwriter outputfile = new StreamWriter(Path.Combine(sortie, "Comptestraités.csv")))
            {
               foreach (string line in lines)
                outputFile.Comptestraités(line);
            }

        }
    } 
}