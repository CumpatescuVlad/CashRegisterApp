using System;
using System.IO;

namespace Transactions
{
    public class DataSource
    {
        private readonly string _connectionString =
            @"Server=tcp:vlad07072003.database.windows.net,1433;Initial Catalog=CashRegisterApp;
            Persist Security Info=False;User ID=Vlad;Password=Apicultor__69;MultipleActiveResultSets=False;
            Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private readonly string _transactionsAmountPath = $@"C:\Users\{Environment.UserName}\Documents\TransactionsAmount.txt";

        public string ConnectionString { get => _connectionString; }

        public string Transactions { get; set; }

        public string TransactionsAmountPath { get => _transactionsAmountPath; }

        public int TotalAmount { get; set; }

        public string TransactionQuerry(string text) => $"Select TransactionNr , Amount , Cif from Transactions Where Cif='{text}'";

        public void Dispose(string path) => File.Delete(path);



    }
}
