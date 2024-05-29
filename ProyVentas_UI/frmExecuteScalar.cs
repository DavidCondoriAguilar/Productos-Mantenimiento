using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar..
using System.Data.SqlClient;

namespace ProyWinC_Sem04
{
    public partial class frmExecuteScalar : Form
    {
        // Creamos las instancias ...
      
        public frmExecuteScalar()
        {
            InitializeComponent();
        }

        private void btnObtenerMaximoPrecio_Click(object sender, EventArgs e)
        {
            try
            {
               // Codifique

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            finally // Finalmente ,Si la conexion esta abierta la cerramos
            {
               // Codifique
            
            }

        }

        private void btnObtenerVentaAnual_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error");
            }
            catch (Exception ex1)
            {

                MessageBox.Show("Error: " + ex1.Message, "Error");
            }
            finally // Finalmente ,si la conexion esta abierta la cerramos
            {
                // Codifique

            }
        }
    }
}
