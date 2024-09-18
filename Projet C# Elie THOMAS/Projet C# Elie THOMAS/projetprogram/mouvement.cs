using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace projetprogram
{
    internal class Mouvements
    {
        internal static void traitenemt()
        {
            int solde;
            int somme;

            foreach (string cpt in transac)
            {
                int i = 1;
                int j;
                string s = "108";
                bool canConvert = long.TryParse(transac[1], out i);
                bool canConvert2 = long.TryParse(fichierC[1], out j);
                bool exp = transac[2] == "0";
                bool des = transac[3] == "0";
                bool exist_exp = transac.Exists(x => x.fichierC[0] == transac[2]);
                bool exist_des = transac.Exists(x => x.fichierC[0] == transac[3]);
                bool positif = transac[1] > 0;
                //  find si les booleen sont bons
                // cas d'un dépot
                switch (cpt)

                    case canConvert == true && exp == false && des == true && exist_des == true:
                    {
                        int solde = fichierC[0] + transac[1];

                    }
                // cas d'un retrait
                case canConvert == true && exp == true && des == false && exist_exp == true:
                    {
                        test retrait max 1000 euros depuis une date précise(partie II)
                                    if (i < 1001)//rajouter conditions entre 2 dates
                            int solde = fichierC[0] - transac[1];

                    }
                //  cas d'un versement
                case canConvert == true && exp == false && des == false && exist_exp == true && exist_des == true && transac[2] != transac[3]:
                    {
                        if (i > j)
                        {
                            int solde = fichierC[0] - transac[1];
                            changer solde compte ou on a versé
                                        }


                    }
                // cas d'un prélèvement
                case canConvert == true && exp == false && des == false && exist_exp == true && exist_des == true && transac[2] != transac[3]:
                    {
                        if ()
                        {
                            test
                                         int solde = fichierC[0] + transac[1];
                            //changer solde compte ou on a versé
                        }


                    }
                default
                        continue






            }
        }
    }
}    