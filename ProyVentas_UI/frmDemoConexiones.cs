using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar
using System.Data.SqlClient;

namespace ProyWinC_Sem04
{
    public partial class frmDemoConexiones : Form
    {
        // Agregue la conexion aqui....

        public frmDemoConexiones()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
            }
            catch (SqlException ex1)
            {
                MessageBox.Show("Error: " + ex1.Message, "Error SQL");
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Error: " + ex2.Message, "Error Generico");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Codifique

        }
    }
}
