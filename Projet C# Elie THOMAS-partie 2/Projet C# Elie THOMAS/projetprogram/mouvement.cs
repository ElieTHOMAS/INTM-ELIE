﻿using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using System.Numerics;

namespace projetprogram2
{/// <summary>
/// PARTIE II: J'ai créé la liste transaction, la partie mouvement est la même que celle de la partie 1, j'ai traité la suppression de compte, et les conditions 
/// de transfert et de création de compte. 
/// </summary>
    internal class Mouvements
    {
        internal static void traitement(List<Transactions> liste_transac, List<Comptes> liste_compte, List<Gestionnaires> liste_gestio)
        {
            int nb_transac = 0;
            foreach (Comptes cpt in liste_compte)
            {

                //booleen pour déterminer s'il s'agit d'une création ou d'une suppression de compte.
                bool entrees = cpt.entree == 0;
                bool sorties = cpt.sortie == 0;

                //Booléens pour vérifier si le gestionnaire indiqué, en entrée ou en sortie, est présent dans le fichier Gestionnaires
                bool exist_gestio_ent = liste_gestio.Exists(gestionnaire => gestionnaire.gest == cpt.entree);
                bool exist_gestio_sor = liste_gestio.Exists(gestionnaire => gestionnaire.gest == cpt.sortie);

                ////creation d'un compte assigné à ce gestionnaire
                //if (exist_gestio_ent == true && entrees == false && sorties == true)
                //{

                ////assigner nb_transac au compteur de traznsactions du nouveau gestinnaire

                //}
                //suppression d'un compte assigné à ce gestionnaire
                if (exist_gestio_sor == true && entrees == true && sorties == false)
                {
                    liste_compte.Remove(cpt);

                }
                ////transfert d'un compte d'un gestionnaire à un autre
                //if (exist_gestio_ent == true && exist_gestio_sor == true && entrees == false && sorties == false)
                //{
                //    //assigner nb_transac au compteur de traznsactions du nouveau gestinnaire

                //}
            }


                decimal somme = 0;
                int compteurs = 0;
                foreach (Transactions tran in liste_transac)
                {
                  
                    // Gestionnaires entree = new Gestionnaires();
                    // Gestionnaires sortie = new Gestionnaires();

                    bool exp = tran.Exp == 0; //On vérifie s'il s'agit d'un dépot
                    bool des = tran.Des == 0; //On vérifie s'il s'agit d'un retrait
                    bool exist_des = liste_compte.Exists(compte => compte.clients == tran.Des);
                    bool exist_exp = liste_compte.Exists(compte => compte.clients == tran.Exp);
                    bool positif = tran.Montant > 0;

                    Comptes destinataire = new Comptes();
                    Comptes expediteur = new Comptes();
                    tran.Statut = "KO";


                    if (exist_des == true && des == false)
                    {
                        destinataire = liste_compte.First(compte => compte.clients == tran.Des);

                    }
                    if (exist_exp == true && exp == false)
                    {
                        expediteur = liste_compte.First(compte => compte.clients == tran.Exp);
                        //Ces 2 variables sont spécifiques aux mouvements ou on enlève de l'argent d'un même compte, et permettent d'établir la condition des 10 derniers retraits < 1001 euros.
                        compteurs = expediteur.compteur;
                        somme = expediteur.cumul;
                    }

                    // cas d'un dépot
                    if (exp == true && des == false && exist_des == true)
                    {
                        destinataire.solde += tran.Montant;
                        tran.Statut = "OK";

                    }
                    // cas d'un retrait
                    if (exp == false && des == true && exist_exp == true && tran.Montant < 1001 && compteurs <= 10 && somme < 10001)
                    {

                        expediteur.solde -= tran.Montant;
                        tran.Statut = "OK";
                        compteurs += 1;
                        somme += tran.Montant;

                    }

                    //  cas d'un versement (ou prélèvement)
                    if (exp == false && des == false && exist_exp == true && exist_des == true && destinataire.clients != expediteur.clients && expediteur.solde > tran.Montant && compteurs <= 10 && somme < 10001)
                    {
                        destinataire.solde += tran.Montant;
                        expediteur.solde -= tran.Montant;
                        tran.Statut = "OK";
                        compteurs += 1;
                        somme += tran.Montant;

                    }

                }

            
        }
    }
}