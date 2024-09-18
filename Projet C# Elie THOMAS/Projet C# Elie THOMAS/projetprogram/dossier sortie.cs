using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace Projet_C__Elie_THOMAS
{
    internal class Output
    {
        internal static void output()
        {
            using (FileStream outputStream = File.OpenWrite(output))
            {
                using (TextWriter redac = new StreamWriter(outputStream))
                {
                    List<string> redac = new List<string>();
                    foreach (string misesajour in sorties)
                    {
                        redac.WriteLine(misesajour);
                    }
                }
            }
        }
    } 
}