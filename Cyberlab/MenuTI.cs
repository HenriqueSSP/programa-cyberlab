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
    public partial class MenuTI : Form
    {

        Thread nt, nt3;
        public MenuTI()
        {
            InitializeComponent();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
                this.Close();
                nt3 = new Thread(novoForm3);
                nt3.SetApartmentState(ApartmentState.STA);
                nt3.Start();
           
        }
        private void novoForm3()
        {
            Application.Run(new agendamentoBD());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm4);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void novoForm4()
        {
            Application.Run(new ClienteBD());
        }
    }
}
