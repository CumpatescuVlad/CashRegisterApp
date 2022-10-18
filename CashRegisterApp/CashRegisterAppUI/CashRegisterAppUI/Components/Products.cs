namespace CashRegisterApp
{
    public class Products
    {

        private readonly string _cif = $"RO{6026346252}";

        public string Name { get; set; }

        public string Price { get; set; }

        public string Barcode { get; set; }

        public int SubTotal { get; set; }

        public int Total { get; set; }

        public string Cif { get => _cif; }

    }
}
