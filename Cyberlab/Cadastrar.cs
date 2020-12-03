using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberlab
{
   public class Cadastrar
    {

        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public String mensagem;

        
        public Cadastrar(String login, String senha ,String nome, String telefone, String email) {

            //Comando SQL -- insert, update, delete
            cmd.CommandText = "Insert into Tecnico (nome_tec,login_tec,senha_tec,celular_tec,email_tec) values (@nome,@login,@senha,@telefone,@email)";
            //parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@email", email);

            try {
                //conectar com banco
                cmd.Connection = conexao.conectar();
                //executar comando 
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostar mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com sucesso!";
            }

            catch (MySqlException) {
                this.mensagem = "Erro ao tentar se conectar ao banco de dados";
            }
          
 
 

        }

    }
}
