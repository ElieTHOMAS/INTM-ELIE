namespace projetprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Transactions> liste_transactions= Transactions.input1();
            List<Comptes> liste_comptes = Comptes.input2();

            Mouvements.traitement(liste_transactions, liste_comptes);
            Output.output(liste_transactions);
        }
        //internal static void operations(liste_transactions, liste_comptes)
        //{

        //}

    }
}
