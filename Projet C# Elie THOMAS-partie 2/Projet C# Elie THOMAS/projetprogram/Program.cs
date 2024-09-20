using System.Collections.Generic;

namespace projetprogram2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Transactions> liste_transactions= Transactions.input1();
            List<Comptes> liste_comptes = Comptes.input2();
            List<Gestionnaires> liste_gest = Gestionnaires.input3();
            Mouvements.traitement(liste_transactions, liste_comptes, liste_gest);
            Output.output(liste_transactions);
        }
       

    }
}
