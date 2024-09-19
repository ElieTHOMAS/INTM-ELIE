using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace projetprogram
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
        internal decimal Montant { get; set; }
        internal int Exp { get; set; }
        internal int Des { get; set; }
        internal string Statut { get; set; }

    
        internal static List<Transactions> input1()
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
                        
                        //Continue to read until you reach end of file

                        while (line != null)
                        {
                            Transactions moves = new Transactions();
                            int b;
                            int c;
                            int d;
                            int e;
                            string[] linesort = line.Split(';');

                            int.TryParse(linesort[0], out b);
                            int.TryParse(linesort[1], out c);
                            int.TryParse(linesort[2], out d);
                            int.TryParse(linesort[3], out e);

                          
                            moves.Id = b;
                            moves.Montant = (decimal)c;
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
            return transac;
        }

    }
}