using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;// Para las clases de acceso a SQL Server
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyWinC_Sem04
{
    public partial class frmConsultaProveedor : Form
    {
       
        public frmConsultaProveedor()
        {
            InitializeComponent();
        }


        //Declaramos las instancias
        SqlConnection cnx = new SqlConnection(@"server=LAPTOP-ORH1E3IB\serverJLEON;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Codifique
            try
            {
           
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }


            }
         
	}

        
    }
}
