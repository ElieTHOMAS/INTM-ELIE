using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using System.Numerics;

namespace projetprogram
{
    internal class Mouvements
    {
        internal static void traitement(List<Transactions> liste_transac, List<Comptes> liste_compte)
        {
            decimal somme;

            foreach (Transactions cpt in liste_transac)
            {

                //on veut un id de la liste de transactions qui corresponde à un id compte
                //Dans liste_compte, existe-il un compte dont la propriete "client" est egale au destinataire de la transaction

                bool exp = cpt.Exp == 0; //On vérifie s'il s'agit d'un dépot
                bool des = cpt.Des == 0; //On vérifie s'il s'agit d'un retrait
                bool exist_des = liste_compte.Exists(compte => compte.clients == cpt.Des);
                bool exist_exp = liste_compte.Exists(compte => compte.clients == cpt.Exp);
                bool positif = cpt.Montant > 0;

                Comptes destinataire = liste_compte.First(compte => compte.clients == cpt.Des);
                Comptes expediteur = liste_compte.First(compte => compte.clients == cpt.Exp);
                cpt.Statut = "KO";


                // cas d'un dépot
                if (exp == true && des == false && exist_des == true)
                {
                    destinataire.solde += cpt.Montant ;
                    cpt.Statut = "OK";
                }
                // cas d'un retrait
                if (exp == false && des == true && exist_exp == true && cpt.Montant < 1001) 
                {
                    expediteur.solde -= cpt.Montant;
                    cpt.Statut = "OK";
                    //somme += cpt.Montant;
                    //assigner une variable a chaque compte qui cumule les retraits
                }
                //test retrait max 1000 euros depuis une date précise(partie ii)
              
                //  cas d'un versement (ou prélèvement)
                if (exp == false && des == false &&  exist_exp == true && exist_des == true && destinataire.clients != expediteur.clients && expediteur.solde > cpt.Montant)
                {
                    destinataire.solde += cpt.Montant;
                    expediteur.solde -= cpt.Montant;
                    cpt.Statut = "OK";
                }
            
            }

        }
    }
}