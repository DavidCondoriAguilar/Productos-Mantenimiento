using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyWinC_Sem04
{
    public partial class frmConsultaCliente : Form
    {
       
        public frmConsultaCliente()
        {
            InitializeComponent();
        }
        //Declaramos las instancias
        SqlConnection cnx = new SqlConnection(@"server=LAPTOP-ORH1E3IB\JLEON;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Codifique
           
            

        }
    }
}
