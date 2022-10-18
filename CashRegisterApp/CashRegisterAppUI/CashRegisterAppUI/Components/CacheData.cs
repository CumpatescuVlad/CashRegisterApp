using System;
using System.IO;

namespace CashRegisterAppUI
{
    public class CacheData
    {
        private int _numberOfArticles = 0;

        private readonly string _cashRegisterDirectory = $@"C:\Users\{Environment.UserName}\Documents\CashRegisterApp";

        private readonly string _numberOfProducts = $@"C:\Users\{Environment.UserName}\Documents\CashRegisterApp\Cache\NumberOfProducts.txt";

        private readonly string _barcode = $@"C:\Users\{Environment.UserName}\Documents\CashRegisterApp\Cache\Barcode.txt";

        private readonly string _productList = $@"C:\Users\{Environment.UserName}\Documents\CashRegisterApp\Cache\ProductList.txt";

        private readonly string _reciptPath = $@"C:\Users\{Environment.UserName}\Documents\CashRegisterApp\Recipt.txt";

        private readonly string _subTotalPath = $@"C:\Users\{Environment.UserName}\Documents\CashRegisterApp\Cache\TotalAmount.txt";

        private readonly string _numberOfArticlesPath = $@"C:\Users\{Environment.UserName}\Documents\CashRegisterApp\Cache\NumberOfArticles.txt";

        public string CashRegisterDirectory { get => _cashRegisterDirectory; }

        public string NumberOfProducts { get => _numberOfProducts; }

        public string ProductList { get => _productList; }

        public string Barcode { get => _barcode; }

        public string NumberOfArticlesPath { get => _numberOfArticlesPath; }

        public string ReciptPath { get => _reciptPath; }

        public string SubTotalPath { get => _subTotalPath; }

        public int NumberOfArticles { get => _numberOfArticles; set => _numberOfArticles = value; }

        public void StoreData(string path, string content) => File.WriteAllText(path, content);

        public void DisposeData(string path) => File.Delete(path);



    }
}
