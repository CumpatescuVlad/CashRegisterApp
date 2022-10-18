using CashRegisterAppUI;
using System;
using System.IO;

namespace CashRegisterApp
{
    public class DatabaseOperations
    {
        #region Objects

        CacheData cache = new CacheData();

        Products product = new Products();

        #endregion

        private readonly string _connectionString =
            @"Server=tcp:vlad07072003.database.windows.net,1433;
            Initial Catalog=CashRegisterApp;Persist Security Info=False;
            User ID=Vlad;Password= Apicultor__69 ;MultipleActiveResultSets=False;
            Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public string ConnectionString { get => _connectionString; }

        public string QuerryString() => $"Select ProductName , Price from Products Where Barcode ='{product.Barcode = File.ReadAllText(cache.Barcode)}'";

        public string InsertString() => $"Insert into Transactions (TransactionNr , Amount ,Cif ) values ('{DateTime.Now.Month}{DateTime.Now.Day}{2022}{File.ReadAllText(cache.SubTotalPath)}', {File.ReadAllText(cache.SubTotalPath)},'{product.Cif}') ";

    }
}
