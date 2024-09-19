using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using projetprogram;

namespace projetprogram
{
    internal class Output
    {
      
        static string sortie = Environment.GetFolderPath("C:\\Users\\Formation\\source\\repos\\INTM-ELIE");
        internal static void output( List<Transactions> liste_transaction)
        {
            using (StreamWriter outputfile = new StreamWriter(Path.Combine(sortie, "Comptestraités.csv")))
            {
                foreach (Transaction line in liste_transaction)
                {
                    outputFile.Writeline(line.Id + ";" + line.Statut);
                }
            }

        }
    } 
}