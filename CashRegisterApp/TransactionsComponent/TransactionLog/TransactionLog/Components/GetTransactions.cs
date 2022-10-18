using System.Data.SqlClient;
using System.IO;

namespace Transactions
{
    public class GetTransactions
    {
        DataSource data = new DataSource();

        public string TransactionLog(string text)
        {
            SqlConnection connection = new SqlConnection(data.ConnectionString);

            connection.Open();

            SqlCommand readTransactions = new SqlCommand(data.TransactionQuerry(text), connection);

            SqlDataReader reader = readTransactions.ExecuteReader();

            while (reader.Read())
            {
                data.Transactions += $"{reader.GetValue(2)}----{reader.GetValue(0)}----{reader.GetValue(1)} Lei\n";
                
                File.WriteAllText(data.TransactionsAmountPath, $"{reader.GetValue(1)}");

                data.TotalAmount+=int.Parse(File.ReadAllText(data.TransactionsAmountPath));

                File.WriteAllText(data.TransactionsAmountPath, $"{data.TotalAmount}");
            }
            reader.Close();

            connection.Close();

            return data.Transactions;

        }

    }
}
