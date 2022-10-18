using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace DatabaseConnection
{
    internal class Program
    {
        //public string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MONEY;Integrated Security=True";
        static void Main(string[] args)
        {
            /*
            Program money = new Program();

            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MONEY;Integrated Security=True");

            connection.Open();

            SqlCommand cmd = new SqlCommand("Select Default from AmountOfMoney",connection);

            cmd.Parameters.AddWithValue("AmountOfMoney", money);

            SqlDataReader reader1 = cmd.ExecuteReader();
            */
          

           // if (reader1.Read())
           // {
              //  Console.WriteLine(reader1["Default"].ToString());
           // }
            //else
           // {
            //    Console.WriteLine("No data fodund");
            //}
            //connection.Close();



            
        }
    }
}
