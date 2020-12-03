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
    public partial class LoginTI : Form
    {
        Thread ti, ls;
        public LoginTI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Controle controle = new Controle();
            controle.acessar(txtLogin.Text, txtSenha.Text);
            if (controle.mensagem.Equals(""))
            {


                if (controle.tem)
                {
                    
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    ls = new Thread(login);
                    ls.SetApartmentState(ApartmentState.STA);
                    ls.Start();

                    
                }
                else
                {
                    MessageBox.Show("Login não encontrado!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show(controle.mensagem);
            }

        }

        private void login()
        {
            Application.Run(new MenuTI());
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ti = new Thread(novatela);
            ti.SetApartmentState(ApartmentState.STA);
            ti.Start();
        }
       
        private void novatela()
        {
            Application.Run(new Menu());
        }
       
    }
}
