using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyberlab
{
    
    public partial class agendamentoBD : Form
    {
        Thread menu_ti;

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
                    txt_data.Text = reader.GetDateTime("data_agen").ToString("dd/MM/yyyy");
                    txt_hora.Text = Convert.ToString(reader["hora_agen"]);

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            menu_ti = new Thread(menu);
            menu_ti.SetApartmentState(ApartmentState.STA);
            menu_ti.Start();
        }

        private void menu()
        {
            Application.Run(new MenuTI());
        }
    }
}
