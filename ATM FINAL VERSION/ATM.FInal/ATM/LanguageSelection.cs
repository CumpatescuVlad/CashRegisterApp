using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class LanguageSelection : UserControl
    {
        public LanguageSelection()
        {
            InitializeComponent();
            
        }

        public void LanguageSelection_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutentificationRomanian authRo = new AutentificationRomanian();
           
            Form1 form = new Form1();

            //form.ControlWork(authRo);

            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
