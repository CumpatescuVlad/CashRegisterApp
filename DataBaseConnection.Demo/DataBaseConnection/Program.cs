using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DataBaseConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = 
                @"Server=tcp:vlad07072003.database.windows.net,1433;Initial Catalog=CashRegisterApp;
                Persist Security Info=False;User ID=Vlad;Password=Apicultor__69;MultipleActiveResultSets=False;
                Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string querryString = "Select ProductName , Price , Barcode from Products";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            Console.WriteLine("Connection is oppened ");

            SqlCommand productCommand=  new SqlCommand(querryString, connection);

            SqlDataReader readProduct = productCommand.ExecuteReader(); 

            while (readProduct.Read())
            {
                Console.WriteLine($"{readProduct.GetValue(0)}----------{readProduct.GetValue(1)}------{readProduct.GetValue(2)}");
            }
            readProduct.Close();


            string insertString = $"Insert into Transactions (TransactionNr , Amount ) values ('45252353','{1234}')";

            SqlCommand insert =  new SqlCommand(insertString, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(insert);

            adapter.InsertCommand = insert;

            adapter.InsertCommand.ExecuteNonQuery();


            connection.Close();
            Console.WriteLine("Closed Connection");



        }
        #region DatabaseConnectionTemplate
        public static void DataBaseConnection()
        {
            //Create connection string
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Initial Catalog =Money;User ID = Vlad;Password =123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string connectionString2 = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Initial Catalog =TableOne;User ID = Vlad;Password =123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //Create a new object out of class sqlconnection with the parameter connection string
            SqlConnection connection = new SqlConnection(connectionString);
            SqlConnection connection2 = new SqlConnection(connectionString2);

            //Open connection
            connection.Open();

            Console.WriteLine("Connection was oppened");
            //Sql command class used to make the querry 
            SqlCommand sqlCmd, sqlCmdSecond;
            //Sql data reader help you execute the command having the querry string parameters and the connection string 
            SqlDataReader reader;
            //String class helps you create a querry string and the output variable
            String sql, sql100, output = "", output100 = "";
            //Querry string
            sql = "Select AmountOfMoney from Money Where AmountOfMoney=200 ";

            sqlCmd = new SqlCommand(sql, connection);
            //Execute the reader
            reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                output += reader.GetValue(0);

            }
            Console.WriteLine($"First amount is : {output}");
            reader.Close();
            sql100 = "Select AmountOfMoney from Money Where AmountOfMoney=100 ";

            sqlCmdSecond = new SqlCommand(sql100, connection);
            reader = sqlCmdSecond.ExecuteReader();
            while (reader.Read())
            {
                output100 += reader.GetValue(0);
            }
            Console.WriteLine($"Second amount is : {output100}");
            connection.Close();

            connection2.Open();

            Console.WriteLine("Connection two  was oppened");

            //SqlCommand sqlCmd2;
           // SqlDataReader reader2;
            //String sql2, output2 = "";
        }
        #endregion 
    }
}
