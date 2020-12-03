using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberlab
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        
        public bool acessar(String login, String senha) {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))//ok
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
    }
}
