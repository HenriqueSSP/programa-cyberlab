using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberlab
{
    public class Conexao
    {

        MySqlConnection con = new MySqlConnection();
        
        //construtor

        public Conexao() {
            con.ConnectionString = @"server=softkleen.com.br;user id=ti87cyberlab;database=wellington_db_cyberlab;port=3306;password=@vn0N6m8";
        }
        //metodo conect

        public MySqlConnection conectar() {
            if (con.State == System.Data.ConnectionState.Closed) {
                con.Open();
            }
            
            return con;
        
        }
        //metodo desconet
        public void desconectar() {

            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }

    }
}
