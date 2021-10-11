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
    public partial class btnTest : Form
    {
        public btnTest()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string connectionString = "";
            MySqlConnection conn;

            try
            {
                connectionString = @"Server=localhost;Database=smis003321;
                 Uid=root; Pwd=usbw;SSL Mode=None";
                conn = new MySqlConnection(connectionString);
                conn.Open();

                //MessageBox.Show("se establece conexion a la base de Datos")
                MetroFramework.MetroMessageBox.Show(this, " Se establecio conexion!",
                    "CONEXION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                conn.Close();
            }
            catch (Exception Ex)

            {
                //MessageBox.Show(Ex.Message)
                MetroFramework.MetroMessageBox.Show(this, Ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnTest_Load(object sender, EventArgs e)
        {

        }
    }
}
