using System;

namespace ATM
{
    internal class Romanian
    {
        AtmProceses perform = new AtmProceses();
        public void RomanianMenu()
        {

            Console.WriteLine("\nIntroduceti Pinul Cardului\n");

            perform.Autentification("\n Pin gresit!!! Incercari ramase");

            AtmOperationSelectorRomanian();

        }

        public static void AtmOperationSelectorRomanian()
        {
            AtmOperations atm = new AtmOperations();

            AtmProceses perform = new AtmProceses();

            Console.WriteLine("\n1.Interogare Sold\n2.Retragere Numerar\n3.Alimentare Card\n");

            int.TryParse(Console.ReadLine(), out int selectedOperation);

            switch (selectedOperation)
            {
                case 1:

                    Console.Write($"\nAveti Disponibil :{atm.Sold()}\n");

                    Console.WriteLine("Doriti Chitanta ?\nApasati 'Y' pentru Da  sau 'N' Pentru Da");

                    perform.AskForRecipt(1, 1);

                    break;

                case 2:

                    Console.WriteLine("Intrduceti Suma: ");

                    atm.Withdraw();

                    Console.WriteLine("Doriti Chitanta ?\nApasati 'Y' pentru Da  sau 'N' Pentru Da");

                    perform.AskForRecipt(1, 2);

                    break;

                case 3:

                    Console.WriteLine("Introduceti Suma");

                    atm.Deposit();

                    Console.WriteLine("Doriti Chitanta ?\nApasati 'Y' pentru Da  sau 'N' Pentru Da");

                    perform.AskForRecipt(1, 3);

                    break;

            }


        }






    }
}
