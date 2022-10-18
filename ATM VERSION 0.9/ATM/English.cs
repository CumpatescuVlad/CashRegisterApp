using System;

namespace ATM
{
    internal class English
    {
        AtmProceses perform = new AtmProceses();
        public void EnglishMenu()
        {

            Console.WriteLine("\nEnter Credit Card Pin\n");

            perform.Autentification("\n Wrong Pin Attempts Remaining");

            AtmOperationSelectorEnglish();

        }

        public static void AtmOperationSelectorEnglish()
        {
            AtmOperations atm = new AtmOperations();

            AtmProceses perform = new AtmProceses();

            Console.WriteLine("\n1.Sold\n2.Withdraw\n3.Deposit\n");

            int.TryParse(Console.ReadLine(), out int selectedOperation);

            switch (selectedOperation)
            {
                case 1:

                    Console.Write($"\nAvailabble Cash :{atm.Sold()}\n");

                    Console.WriteLine("Do you want a recipt ?\nPress 'Y' for Yes  or 'N' for No");

                    perform.AskForRecipt(2, 1);

                    break;

                case 2:

                    Console.WriteLine("Enter Amount: ");

                    atm.Withdraw();

                    Console.WriteLine("Do you want a recipt ?\nPress 'Y' for Yes  or 'N' for No");

                    perform.AskForRecipt(2, 2);

                    break;

                case 3:

                    Console.WriteLine("Enter Amount");

                    atm.Deposit();

                    Console.WriteLine("Do you want a recipt ?\nPress 'Y' for Yes  or 'N' for No");

                    perform.AskForRecipt(2, 3);

                    break;

            }


        }


    }
}
