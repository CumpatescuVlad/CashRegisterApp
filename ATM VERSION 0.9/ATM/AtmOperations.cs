using System;
using System.IO;

namespace ATM
{
    internal class AtmOperations
    {
        AtmData stored = new AtmData();

        public int Sold()
        {

            int.TryParse(File.ReadAllText(stored.MoneyPath), out int money);

            File.WriteAllText(stored.SoldAmountPath, $"{money}");

            return money;
        }
        public void Withdraw()
        {
            int.TryParse(Console.ReadLine(), out int withdrawlAmount);

            File.WriteAllText(stored.WithdrawedAmountPath, $"{withdrawlAmount}");

            stored.AmountOfMoney = Int32.Parse(File.ReadAllText(stored.MoneyPath));

            File.WriteAllText(stored.MoneyPath, $"{stored.AmountOfMoney -= withdrawlAmount}");




        }
        public void Deposit()
        {

            int.TryParse(Console.ReadLine(), out int amountToDeposit);

            File.WriteAllText(stored.DepositAmountPath, $"{amountToDeposit}");

            stored.AmountOfMoney = Int32.Parse(File.ReadAllText(stored.MoneyPath));

            File.WriteAllText(stored.MoneyPath, $"{stored.AmountOfMoney += amountToDeposit}");



        }


    }
}
