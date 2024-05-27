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
    public partial class ProveedorMan03 : Form
    {
        
        ProveedorBL objProveedorBL = new ProveedorBL();
        ProveedorBE objProveedorBE = new ProveedorBE();
            

        public ProveedorMan03()
        {
            InitializeComponent();
        }

        // IMPORTANTE: Creamos la propiedad Codigo ,que recepcionara el valor del codigo del proveedor
        // a actualizar enviado desde el formulario ProveedorMan01
        
        
        public String Codigo {get; set;}
        
         private void ProveedorMan03_Load(object sender, EventArgs e)
        {
            try
            {
                 


               
               



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            // Codifique...
           


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
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(),
                                cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       

       
    }
}
