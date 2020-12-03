using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberlab
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";//tudo ok
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();
        MySqlDataReader dr;
        public bool verificarLogin(String login, String senha) {
            //comandos MySql para verificar se tem no banco
            cmd.CommandText = "select * from RH where login_rh = @login and senha_rh = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro ao conectar no Banco de Dados!!";
               
            }
            return tem;
        }


    }
}
