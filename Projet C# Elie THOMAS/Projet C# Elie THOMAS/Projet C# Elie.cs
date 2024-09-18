using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace Projet_C__Elie_THOMAS
{

    //On a 2 fichiers test en entrée, 'Comptes' et 'transactions', 1 fichier créé en sortie.
    //Comptes: n°compte;solde transactions       Transactions: n°transactions; somme mouvement; cpte expéditeur (0 = dépot); cpte destinataire (0=retrait)
    //A prendre en compte: fichier compte doit reconnaitre cpte exp et/ou dest; somme des 10 derniers retraits <= 1000; sinon retrait KO, que des valeurs numériques dans les 2 fichiers
    //identifiant transaction unique, ne peut être présent qu'une fois dans le fichier transaction; exp et dest ne peuvent pas être le même numéro de compte

    //classe transactions
    internal class Transactions
    {
        static string transactions = @"C:\\Users\\Formation\\source\\repos\\INTM-ELIE\\transactions.csv";
        static List<Transactions> transac;

        internal int Id { get; set; }
        internal int Montant { get; set; }
        internal int Exp { get; set; }
        internal int Des { get; set; }
        internal static void Main()
        {
            input1();
        }

        internal static void input1()
        {
            string line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                //StreamReader sr = new StreamReader(input);
                using (FileStream inputStream = File.OpenRead(transactions))
                {
                    using (TextReader reader = new StreamReader(inputStream))
                    {
                        transac = new List<Transactions>();
                        line = reader.ReadLine();
                        string[] linesort = line.Split(';');
                        //Continue to read until you reach end of file

                        while (line != null)
                        {
                            Transactions moves = new Transactions();
                            int b;
                            int c;
                            int d;
                            int e;
                            int.TryParse(linesort[0], out b);
                            int.TryParse(linesort[1], out c);
                            int.TryParse(linesort[2], out d);
                            int.TryParse(linesort[3], out e);

                            moves.Id = b;
                            moves.Montant = c;
                            moves.Exp = d;
                            moves.Des = e;
                            transac.Add(moves);                        
                            line = reader.ReadLine();
                        }
                    }
                }

            }
            catch
            {
                Console.WriteLine("problème d'ouverture du fichier transactions ");
            }
        }

    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    internal class Comptes
    {
        static string comptes = @"C:\\Users\\Formation\\source\\repos\\INTM-ELIE\\compte.csv";
        static List<Comptes> fichierC;
        internal int clients { get; set; }
        internal int soldes { get; set; }

 
        internal static void input2()
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


            //        using (FileStream outputStream = File.OpenWrite(output))
            //        {
            //            using (TextWriter redac = new StreamWriter(outputStream))
            //            {
            //                List<string> redac = new List<string>();
            //                foreach (string misesajour in sorties)
            //                {
            //                    redac.WriteLine(misesajour);
            //                }
            //            }
            //        }
            //    }
            //    internal static void traitenemt()
            //    {
            //        int solde;
            //        int somme;

            //        foreach (string cpt in transac)
            //        {
            //            int i = 1;
            //            int j;
            //            string s = "108";
            //            bool canConvert = long.TryParse(transac[1], out i);
            //            bool canConvert2 = long.TryParse(fichierC[1], out j);
            //            bool exp = transac[2] == "0";
            //            bool des = transac[3] == "0";
            //            bool exist_exp = transac.Exists(x => x.fichierC[0] == transac[2]);
            //            bool exist_des = transac.Exists(x => x.fichierC[0] == transac[3]);
            //            bool positif = transac[1] > 0;
            //            find si les booleen sont bons
            //                        cas d'un dépot
            //                        switch (cpt)

            //                        case canConvert == true && exp == false && des == true && exist_des == true:
            //                {
            //                    int solde = fichierC[0] + transac[1];

            //                }
            //                cas d'un retrait
            //                        case canConvert == true && exp == true && des == false && exist_exp == true:
            //                {
            //                    test retrait max 1000 euros depuis une date précise(partie II)
            //                            if (i < 1001)//rajouter conditions entre 2 dates
            //                        int solde = fichierC[0] - transac[1];

            //                }
            //                cas d'un versement
            //                        case canConvert == true && exp == false && des == false && exist_exp == true && exist_des == true && transac[2] != transac[3]:
            //                {
            //                    if (i > j)
            //                    {
            //                        int solde = fichierC[0] - transac[1];
            //                        changer solde compte ou on a versé
            //                            }


            //                }
            //                cas d'un prélèvement
            //                        case canConvert == true && exp == false && des == false && exist_exp == true && exist_des == true && transac[2] != transac[3]:
            //                {
            //                    if ()
            //                    {
            //                        test
            //                                int solde = fichierC[0] + transac[1];
            //                        changer solde compte ou on a versé
            //                            }


            //                }
            //            default
            //                            continue
            //                    }


            //            //        }


        }
    }
}




