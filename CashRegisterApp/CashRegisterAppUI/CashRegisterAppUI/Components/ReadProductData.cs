using CashRegisterApp;
using System.Data.SqlClient;
using System.IO;

namespace CashRegisterAppUI
{
    public class ReadProductData
    {

        public void AddProducts()
        {
            #region Objects

            CacheData cache = new CacheData();

            DatabaseOperations data = new DatabaseOperations();

            SqlConnection connection = new SqlConnection(data.ConnectionString);

            Products product = new Products();

            #endregion

            connection.Open();

            SqlCommand command = new SqlCommand(data.QuerryString(), connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                product.Name += reader.GetValue(0);

                product.Price = $"{reader.GetValue(1)}";

            }
            reader.Close();

            connection.Close();

            int numberOfProducs = int.Parse(File.ReadAllText(cache.NumberOfProducts));

            int finalPrice = int.Parse(product.Price) * numberOfProducs;

            File.AppendAllText(cache.ReciptPath, $"{product.Name} ----------- {numberOfProducs} BUC  X {product.Price} = {finalPrice}.00 Lei\n");

            File.AppendAllText(cache.ProductList, $"{product.Name} ----------- {numberOfProducs} BUC  X {product.Price} = {finalPrice}.00 Lei\n");

            product.SubTotal = int.Parse(File.ReadAllText(cache.SubTotalPath));

            File.WriteAllText(cache.SubTotalPath, $"{finalPrice + product.SubTotal}");

        }

    }

}
