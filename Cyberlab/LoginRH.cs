using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Cyberlab
{
    public partial class LoginRH : Form
    {
        Thread rh, ls;
        public LoginRH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "cyberstandard" && textBox2.Text == "standard2019")
            {
                this.Close();
                ls = new Thread(login);
                ls.SetApartmentState(ApartmentState.STA);
                ls.Start();
         
            }

            else
            {
                MessageBox.Show("Login ou Senha Inválidos");
                
            }
        }

        private void login()
        {
            Application.Run(new CadastroTI());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            rh = new Thread(novatela);
            rh.SetApartmentState(ApartmentState.STA);
            rh.Start();

        }

        private void novatela()
        {
            Application.Run(new Menu());
        }
    }
}
