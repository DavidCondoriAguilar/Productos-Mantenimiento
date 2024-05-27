using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Agregar...
using ProyVentas_BL;
using ProyVentas_BE;
namespace ProyVentas_GUI
{
    public partial class ProveedorMan02 : Form
    {
        
        ProveedorBL objProveedorBL = new ProveedorBL();
        ProveedorBE objProveedorBE = new ProveedorBE();
            

        public ProveedorMan02()
        {
            InitializeComponent();
        }

        private void ProveedorMan02_Load(object sender, EventArgs e)
        {
            try
            {
                
                // Cargamos los combos de Ubigeo
                // Por defecto elegiremos Lima, Lima , Lima (14,01,01)
                CargarUbigeo("14","01","01");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            
            }
        }

        private void CargarUbigeo(String IdDepa,String IdProv,String IdDist)
        {
           // Codifique
          


        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }


        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");

        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");


        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
