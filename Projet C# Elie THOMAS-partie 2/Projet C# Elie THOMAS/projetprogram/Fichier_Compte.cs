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
        static string comptes = @"C:\\Users\\Formation\\source\\repos\\INTM-ELIE\\\Projet C# Elie THOMAS-partie 2\\compte.csv";
        static List<Comptes> fichierC;
        internal int clients { get; set; }
        internal string date { get; set; }
        internal decimal solde { get; set; }
        internal int entree { get; set; }
        internal int sortie { get; set; }
        internal int compteur { get; set; }
        internal decimal cumul { get; set; }
      

        C:\Users\Formation\source\repos\INTM-ELIE\Projet C# Elie THOMAS-partie 2
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
                            string date;
                            int ent;
                            int sor;
                            int.TryParse(linesort[0], out b);
                            int.TryParse(linesort[1], out c);

                            accounts.clients = b;
                            accounts.solde = c;
                            accounts.date = date;
                            accounts.entree = ent;
                            accounts.sortie = sor;
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