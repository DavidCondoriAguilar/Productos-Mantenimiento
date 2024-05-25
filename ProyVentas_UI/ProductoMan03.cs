using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregamos
using ProyVentas_BE;
using ProyVentas_BL;
namespace ProyVentas_GUI
{
    public partial class ProductoMan03 : Form
    {
        // Instancias...
        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();
        UnidadMedidaBL objUnidadMedidaBL = new UnidadMedidaBL();
        CategoriaBL objCategoriaBL = new CategoriaBL();

        public ProductoMan03()
        {
            InitializeComponent();
        }

        // Propiedad que recibe el codigo del producto que se actualizara, enviado
        // desde el ProductoMan01

        public String Codigo { get; set; }

        private void ProductoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos los combos...
                DataTable dt = objCategoriaBL.ListarCategoria();
                DataRow dr;

                dr = dt.NewRow();
                dr["Id_cat"] = 0;
                dr["Des_cat"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboCategoria.DataSource = dt;
                cboCategoria.ValueMember = "Id_cat";
                cboCategoria.DisplayMember = "Des_cat";

                dt = objUnidadMedidaBL.ListarUM();
                dr = dt.NewRow();
                dr["Id_UM"] = 0;
                dr["Des_UM"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboUM.DataSource = dt;
                cboUM.DisplayMember = "Des_UM";
                cboUM.ValueMember = "Id_UM";

                // Codifique                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back
                    || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator);
        }

        private void txtStkAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }
    }
}
