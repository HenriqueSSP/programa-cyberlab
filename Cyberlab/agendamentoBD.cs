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
    public partial class agendamentoBD : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();
        MySqlDataReader reader;

        public agendamentoBD()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //string sql = 
            cmd.CommandText = "SELECT * FROM Agendamentos, Clientes WHERE nome_cli=@nome";
            cmd.Parameters.AddWithValue("@nome", txt_pesquisar.Text);
            cmd.CommandType = CommandType.Text;

            //conexao Banco de Dados
            try
            {
                cmd.Connection = con.conectar();
                reader = cmd.ExecuteReader();
                //verificando se cliente existe no Banco
                if (reader.Read())
                {
                    txt_nome.Text = Convert.ToString(reader["nome_cli"]);
                    txt_tipo.Text = Convert.ToString(reader["tipo_agen"]);
                    txt_data.Text = Convert.ToString((double)reader["data_agen"]);
                    txt_hora.Text = Convert.ToString((double)reader["hora_agen"]);

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
