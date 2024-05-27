using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Agregar...
using ProyVentas_BL;

namespace ProyVentas_GUI
{
    public partial class ProveedorMan01 : Form
    {
       
        ProveedorBL objProveedorBL = new ProveedorBL();
        DataView dtv;
       
       
        public ProveedorMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {
            // Codifique
        }

        private void ProveedorMan01_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           try
            {
               //Codifique

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            try
            {
               //Codifique
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //Codifique
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
