﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projet_C__Elie_THOMAS
{

    //On a 2 fichiers test en entrée, 'Comptes' et 'transactions', 1 fichier créé en sortie.
    //Comptes: n°compte;solde transactions       Transactions: n°transactions; somme mouvement; cpte expéditeur (0 = dépot); cpte destinataire (0=retrait)
    //A prendre en compte: fichier compte doit reconnaitre cpte exp et/ou dest; somme des 10 derniers retraits <= 1000; sinon retrait KO, que des valeurs numériques dans les 2 fichiers
    //identifiant transaction unique, ne peut être présent qu'une fois dans le fichier transaction; exp et dest ne peuvent pas être le même numéro de compte
    internal class Comptes
    {
        internal static string path = Directory.GetCurrentDirectory();
        static string comptes = path + @"\compte.csv";
        static string transactions = path + @"\transactions.csv";
        static List<string> fichierC;
        static List<string> transac;
        internal static void Main()
        {
            input();
        }
        internal static void input()
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
                        fichierC = new List<string>();
                        line = reader.ReadLine();
                        string[] linesort = line.Split(';');
                        //Continue to read until you reach end of file

                        while (reader != null)
                        {
                            fichierC.Add(line);
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("problème d'ouverture du fichier Compte ");
            }
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                //StreamReader sr = new StreamReader(input);
                using (FileStream inputStream = File.OpenRead(transactions))
                {
                    using (TextReader reader = new StreamReader(inputStream))
                    {
                        List<string> transac = new List<string>();
                        line = reader.ReadLine();
                        string[] linesort = line.Split(';');
                        //Continue to read until you reach end of file

                        while (reader != null)
                        {
                            transac.Add(line);
                        }
                    }
                }

            }
            catch
            {
                Console.WriteLine("problème d'ouverture du fichier transactions ");
            }
        }
        internal static void traitenemt()
        {
            foreach (string ligne in transac)
            {
                bool canConvert = long.TryParse(transac, out number1);
                if (canConvert == true)


            }
               

        }


}
}

