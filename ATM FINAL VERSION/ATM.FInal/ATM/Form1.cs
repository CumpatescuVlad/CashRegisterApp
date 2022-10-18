using System.Security.Cryptography.X509Certificates;

namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            languageSelection1.SendToBack();
            autentificationRomanian1.SendToBack();
        }
       public void DisplayAuthRom()
       {
            autentificationRomanian1.BringToFront();
            

       }

        private void autentificationRomanian1_Load(object sender, EventArgs e)
        {

        }
        public void ControlWork(Control control ,Control content)
        {
            content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            content.Controls.Add(control);
            
        }
    }
}