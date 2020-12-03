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
            btn_editar.Enabled = false;
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
                    btn_editar.Enabled = true;
                   
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

        private void btn_editar_Click(object sender, EventArgs e)
        {


            //conexao Banco de Dados
            try
            {
                ///string sql = 


                cmd.CommandText = "UPDATE Clientes , Tel_cli SET nome_cli=@nomeUp, email_cli=@emailUp, endereco_cli=@enderecoUp, login_cli=@loginUp , senha_cli=@senhaUp, telefone_cli=@telefoneUp";
                cmd.Parameters.AddWithValue("@nomeUp", txt_nome.Text);
                cmd.Parameters.AddWithValue("@emailUp", txt_email.Text);
                cmd.Parameters.AddWithValue("@enderecoUp", txt_endereco.Text);
                cmd.Parameters.AddWithValue("@loginUp", txt_login.Text);
                cmd.Parameters.AddWithValue("@senhaUp", txt_senha.Text);
                cmd.Parameters.AddWithValue("@telefoneUp", maskedTextBox1.Text);

                cmd.CommandType = CommandType.Text;

                cmd.Connection = con.conectar();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Alterado com sucesso!!");
                //verificando se cliente existe no Banco
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
