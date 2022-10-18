namespace ATM
{
    internal class AtmData
    {

        private readonly int _creditCardPin = 7757;

        private int _amountOfMoney = 0;

        public readonly string _directoryPath = @"C:\Users\VLAD\Documents\ATM";

        private readonly string _billPath = @"C:\Users\VLAD\Documents\ATM\Bill.txt";

        private readonly string _moneyPath = @"C:\Users\VLAD\Documents\ATM\Money.txt";

        private readonly string _withdrawedAmountPath = @"E:\CODE REPOS\CustomerBankDatabaseSimulator\ATM\ATM\WithdrawedAmount.txt";

        private readonly string _depositAmountPath = @"E:\CODE REPOS\CustomerBankDatabaseSimulator\ATM\ATM\DepositAmount.txt";

        private readonly string _soldtAmountPath = @"E:\CODE REPOS\CustomerBankDatabaseSimulator\ATM\ATM\SoldAmount.txt";
        public string BillPath { get => _billPath; }
        public string MoneyPath { get => _moneyPath; }
        public int Language { get; set; }
        public string SoldAmountPath { get => _soldtAmountPath; }
        public string WithdrawedAmountPath { get => _withdrawedAmountPath; }
        public string DepositAmountPath { get => _depositAmountPath; }
        public int CreditCardPin { get => _creditCardPin; }
        public int AmountOfMoney { get => _amountOfMoney; set => _amountOfMoney = value; }



    }
}
