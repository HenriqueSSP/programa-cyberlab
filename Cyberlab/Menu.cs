using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Cyberlab
{
    public partial class Menu : Form
    {
        Thread nt, nt2;

        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            nt2 = new Thread(novoForm2);
            nt2.SetApartmentState(ApartmentState.STA);
            nt2.Start();
        }

        

        private void novoForm()
            {
            Application.Run(new LoginRH());
            }

        private void novoForm2()
        {
            Application.Run(new LoginTI());
        }
    }
   
    
}
