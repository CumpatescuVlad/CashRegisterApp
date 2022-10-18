using System;
using System.IO;

namespace ATM
{
    internal class AtmProceses
    {
        AtmData stored = new AtmData();
        
        public string Autentification(string userMessage)
        {
            int readPin = int.Parse(Console.ReadLine());

            if (readPin == stored.CreditCardPin)
            {
              
                return "";

            }
            
            else
            {
                for (int i = 2; i >= 1; i--)
                {

                    Console.WriteLine($"{userMessage}:{i}");

                    Console.Write("Pin: ");

                    readPin = int.Parse(Console.ReadLine());

                    if (readPin == stored.CreditCardPin)
                    {
                        return " Pin Correct";

                    }
                    
                }

                 Environment.Exit(0);

               return "";

            }

        }

        public void AskForRecipt(int language, int typeOfRecipt)
        {
            Recipt generate = new Recipt();

            char.TryParse(Console.ReadLine(), out char userResponse);

            bool romanianIsSelected = language == 1;

            bool responseIsPositive = userResponse == 'y';

            if (responseIsPositive is true && romanianIsSelected is true && typeOfRecipt == 3)
            {
                generate.CreateDepositRecipt(1);

                return;
            }
            else if (responseIsPositive is true && romanianIsSelected is false && typeOfRecipt == 3)
            {
                generate.CreateDepositRecipt(2);

                return;
            }
            else if (responseIsPositive is true && romanianIsSelected is true && typeOfRecipt == 1)
            {
                generate.CreateSoldRecipt(1);

                return;
            }
            else if (responseIsPositive is true && romanianIsSelected is false && typeOfRecipt == 1)
            {
                generate.CreateSoldRecipt(2);

                return;
            }
            else if (responseIsPositive is true && romanianIsSelected is true && typeOfRecipt == 2)
            {
                generate.CreateWithdrawRecipt(1);

                return;
            }
            else if (responseIsPositive is true && romanianIsSelected is false && typeOfRecipt == 2)
            {
                generate.CreateWithdrawRecipt(2);

                return;
            }





        }

    }
}
