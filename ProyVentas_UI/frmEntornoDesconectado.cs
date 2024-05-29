using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProyWinC_Sem04
{
    public partial class frmEntornoDesconectado : Form
    {
        //Declaramos las instancias
        SqlConnection cnx = new SqlConnection(@"server=LAPTOP-ORH1E3IB\JLEON;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter ada;

        public frmEntornoDesconectado()
        {
            InitializeComponent();
        }

        private void frmEntornoDesconectado_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                lblCod1.Text = cboCliente.SelectedValue.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
