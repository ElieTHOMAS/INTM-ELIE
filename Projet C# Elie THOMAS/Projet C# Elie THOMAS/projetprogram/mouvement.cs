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
           
            int compteurs = 0;
            decimal somme = 0;
            //On boucle sur chaque ligne de la transaction

            foreach (Transactions cpt in liste_transac)
            {
                //on veut un id de la liste de transactions qui corresponde à un id compte
                //Dans liste_compte, existe-il un compte dont l'attribut "client" est egale au destinataire de la transaction

                bool exp = cpt.Exp == 0; //On vérifie s'il s'agit d'un dépot
                bool des = cpt.Des == 0; //On vérifie s'il s'agit d'un retrait
               // bool solde_null;
                bool exist_des = liste_compte.Exists(compte => compte.clients == cpt.Des);
                bool exist_exp = liste_compte.Exists(compte => compte.clients == cpt.Exp);
                bool positif = cpt.Montant > 0;

                Comptes destinataire = new Comptes();
                Comptes expediteur = new Comptes();
                cpt.Statut = "KO";


                if (exist_des == true && des == false )
                {
                    destinataire = liste_compte.First(compte => compte.clients == cpt.Des);
                    compteurs = destinataire.compteur;
                    somme = destinataire.cumul;
                }
                if (exist_exp == true && exp == false)
                {
                    expediteur = liste_compte.First(compte => compte.clients == cpt.Exp);
                  
                }
 
                // cas d'un dépot
                if (exp == true && des == false && exist_des == true)
                {
                    destinataire.solde += cpt.Montant ;
                    cpt.Statut = "OK";

                }
                // cas d'un retrait
                if (exp == false && des == true && exist_exp == true && cpt.Montant < 1001 && compteurs <= 10 && somme < 1001) 
                {
                 
                    expediteur.solde -= cpt.Montant;
                    cpt.Statut = "OK";
                    compteurs += 1;
                    somme += cpt.Montant;
                    
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