using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace projetprogram
{
    internal class Comptes
    {
        static string comptes = @"C:\\Users\\Formation\\source\\repos\\INTM-ELIE\\compte.csv";
        static List<Comptes> fichierC;
        internal int clients { get; set; }
        internal int soldes { get; set; }


        internal static List<Comptes> input2()
        {
            string line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                //StreamReader sr = new StreamReader(input);
                using (FileStream inputStream = File.OpenRead(comptes))
                {
                    using (TextReader reader = new StreamReader(inputStream))
                    {
                        fichierC = new List<Comptes>();
                        line = reader.ReadLine();
                        string[] linesort = line.Split(';');
                        //Continue to read until you reach end of file

                        while (line != null)
                        {
                            Comptes accounts = new Comptes();
                            int b;
                            int c;
                            int.TryParse(linesort[0], out b);
                            int.TryParse(linesort[1], out c);

                            accounts.clients = b;
                            accounts.soldes = c;
                            fichierC.Add(accounts);
                            line = reader.ReadLine();
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("problème d'ouverture du fichier Compte ");
            }
            return fichierC;
        }
    }
}