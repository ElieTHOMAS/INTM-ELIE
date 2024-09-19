using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    public static class ClassCouncil
    {
        static void Main(string[] args)
        {
            SchoolMeans("Input.csv", "Output.csv");
        }

        static string[] Moyennes(List<string> entrees)
        {
            double HTotal = 0;
            double MTotal = 0;
            int nombreH = 0;
            int nombreM = 0;
            foreach (string ligne in entrees)
            {
                string matiere = ligne.Split(';')[1];
                string note = ligne.Split(';')[2];

                if (matiere == "Histoire")
                {
                    HTotal += double.Parse(note);
                    nombreH += 1;
                }
                else if (matiere == "Maths")
                {
                    MTotal += double.Parse(note);
                    nombreM += 1;
                }
            }

            double histMoyenne = HTotal / nombreH;
            double mathMoyenne = MTotal / nombreM;
            string[] sorties = new string[2];
            sorties[0] = "Histoire;" + histMoyenne.ToString();
            sorties[1] = "Maths;" + mathMoyenne.ToString();
           
            return (sorties);
        }
          


        public static void SchoolMeans(string input, string output)
        {
          //  using (Stream s = new FileStream(" result.csv ", FileMode.Create)) ;
          string line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                //StreamReader sr = new StreamReader(input);
                using (FileStream inputStream = File.OpenRead(input)) 
                {
                    using (TextReader reader = new StreamReader(inputStream)) 
                    {
                        List<string> ent = new List <string>();
                        //Read the first line of text
                        line = reader.ReadLine();
                        string[] linesort = line.Split(';');
                        //Continue to read until you reach end of file
                        while (reader != null)
                        {
                            ent.Add(line);
                        }
                        string [] sorties = Moyennes(ent);
                        using (FileStream outputStream = File.OpenWrite(output))
                        {
                          using (TextWriter redac = new StreamWriter(outputStream))
                          {
                            foreach (string ligne in sorties)
                            {
                               redac.WriteLine(ligne);
                            }
                          }
                        }
                    }   
                }
            }
               
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
