using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Practica0710
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                //instanciamos al formulario
                frmTest frm = new frmTest();

                frm.MdiParent = this; //definir formulario padre
                frm.Show(); // mostrar formulario
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fmr = new frmCliente();

            fmr.MdiParent = this;
            fmr.Show();
        }
    }
}
