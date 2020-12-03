using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyberlab
{
    public partial class CadastroTI : Form
    {
        public CadastroTI()
        {
            InitializeComponent();
        }

        private void tiBD_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar(TxbLogin.Text,TxbSenha.Text,txbNome.Text, txbTelefone.Text, TxbEmail.Text);
            MessageBox.Show(cad.mensagem);
        }

        private void Senha_Click(object sender, EventArgs e)
        {

        }
    }
}
