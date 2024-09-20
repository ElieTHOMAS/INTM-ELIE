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
    internal class Comptes
    {
        static string comptes = @"C:\\Users\\Formation\\source\\repos\\INTM-ELIE\\\Projet C# Elie THOMAS-partie 2\\Comptes.csv";
        static List<Comptes> fichierC;
        internal int clients { get; set; }
        internal DateTime date { get; set; }
        internal decimal solde { get; set; }
        internal int entree { get; set; }
        internal int sortie { get; set; }
        internal int compteur { get; set; }
        internal decimal cumul { get; set; }
      

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
                 

                            int.TryParse(linesort[0], out int ident);
                            DateTime.TryParse(linesort[1], out DateTime date1);
                            decimal.TryParse(linesort[2], out decimal sol);
                            int.TryParse(linesort[3], out int ent);
                            int.TryParse(linesort[4], out int sor);

                            accounts.clients = ident;
                            accounts.date = date1;
                            accounts.solde = sol;
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