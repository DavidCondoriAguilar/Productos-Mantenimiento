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
    public partial class frmUMedida : Form
    {

        SqlConnection cnx = new SqlConnection(@"server=LAPTOP-ORH1E3IB\JLEON;Database=VentasLeon;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter ada;
        

        public frmUMedida()
        {
            InitializeComponent();
        }

        private void frmDistritos1_Load(object sender, EventArgs e)
        {
            try
            {
                
                // LLenamos el grid...
                Listar();

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
               // Codifique...
               
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();

                }
                Listar();
            }

        }
        private void Listar()
        {
            
            

        }
    }
}
