using MySql.Data.MySqlClient;
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
    public partial class ClienteBD : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();
        MySqlDataReader reader;
                        
        public ClienteBD()
        {
            InitializeComponent();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }
        //Buscando dados do cliente no Banco
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //string sql = 
            cmd.CommandText = "SELECT * FROM Clientes , Tel_cli WHERE nome_cli=@nome";
            cmd.Parameters.AddWithValue("@nome", txt_pesquisar.Text);
            cmd.CommandType = CommandType.Text;
            
                //conexao Banco de Dados
            try {
                cmd.Connection = con.conectar();
                reader = cmd.ExecuteReader();
                //verificando se cliente existe no Banco
                if (reader.Read())
                {
                    txt_nome.Text = Convert.ToString(reader["nome_cli"]);
                    txt_email.Text = Convert.ToString(reader["email_cli"]);
                    txt_endereco.Text = Convert.ToString(reader["endereco_cli"]);
                    txt_login.Text = Convert.ToString(reader["login_cli"]);
                    txt_senha.Text = Convert.ToString(reader["senha_cli"]);
                    maskedTextBox1.Text = Convert.ToString(reader["telefone_cli"]);
                   
                }
                else
                    MessageBox.Show("Nenhum Registro Encontrado com o Nome Informado!");
            }
            
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                 {
                con.desconectar();
                 }

        }
    }
}
