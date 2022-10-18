using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GtaCheatsSearchApp
{

    public partial class Gta5Cheats : UserControl
    {
        public Gta5Cheats()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchGTA5Cheat();

        }
       
        public void SearchGTA5Cheat()
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog =GTA;User ID =Vlad;Password=123;
                                      Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                      ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string selectCheat = $"Select Cheats,Action from GTA5Cheats Where Action='{textBox1.Text}'";

            string selectAllCheats = $"Select Cheats,Action from GTA5Cheats";

            string displayAllCheats = "";

            if (textBox1.Text == "all" || textBox1.Text == "All")
            {
                AllCheats allCheats = new AllCheats();

                SqlCommand selectAll = new SqlCommand(selectAllCheats, connection);

                SqlDataReader readAll = selectAll.ExecuteReader();

                while (readAll.Read())
                {
                    displayAllCheats += $"{readAll.GetValue(0)}---Cheat Used For---{readAll.GetValue(1)}\n";

                }
                allCheats.Show();

                allCheats.DisplayAllCheats(displayAllCheats);

                readAll.Close();

            }

            SqlCommand selectOneCheat = new SqlCommand(selectCheat, connection);

            SqlDataReader readCheat = selectOneCheat.ExecuteReader();

            string cheat = "";

            while (readCheat.Read())
            {
                cheat += $"{readCheat.GetValue(0)}---Cheat Used For---{readCheat.GetValue(1)}\n";

            }
            textBox1.Text = cheat;

            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();




        }
    }
}
