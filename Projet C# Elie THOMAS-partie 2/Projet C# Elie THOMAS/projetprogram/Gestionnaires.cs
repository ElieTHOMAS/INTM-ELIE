using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projetprogram2
{
    internal class Gestionnaires
    {
        static string gestionnaires = @"C:\\Users\\Formation\\source\\repos\\INTM-ELIE\\\Projet C# Elie THOMAS-partie 2\\Gestionnaires.csv";
        static List<Gestionnaires> fichierG;
        internal int gest { get; set; }
        internal string type { get; set; }
        internal int nb_transactions { get; set; }



        internal static List<Gestionnaires> input3()
        {
            string line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                //StreamReader sr = new StreamReader(input);
                using (FileStream inputStream = File.OpenRead(gestionnaires))
                {
                    using (TextReader reader = new StreamReader(inputStream))
                    {
                        fichierG = new List<Gestionnaires>();
                        line = reader.ReadLine();
                        string[] linesort = line.Split(';');
                        //Continue to read until you reach end of file

                        while (line != null)
                        {
                            Gestionnaires gestio = new Gestionnaires();

                            int.TryParse(linesort[0], out int ges);
                            string type1 = linesort[1];
                            int.TryParse(linesort[2], out int nombreT);

                            gestio.gest = ges;
                            gestio.type = type1;
                            gestio.nb_transactions = nombreT;
                            
                            fichierG.Add(gestio);
                            line = reader.ReadLine();
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("problème d'ouverture du fichier Compte ");
            }
            return fichierG;
        }
    }
}