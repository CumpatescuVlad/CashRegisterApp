using CashRegisterApp;
using System.Data.SqlClient;

namespace CashRegisterAppUI
{
    public class InsertTransaction
    {
        public void PushTransactionData()
        {
            DatabaseOperations data = new DatabaseOperations();

            SqlConnection connection = new SqlConnection(data.ConnectionString);

            connection.Open();

            SqlCommand insertTransaction = new SqlCommand(data.InsertString(), connection);

            SqlDataAdapter adapter = new SqlDataAdapter(insertTransaction);

            adapter.InsertCommand = insertTransaction;

            adapter.InsertCommand.ExecuteNonQuery();

            connection.Close();

        }


    }
}
