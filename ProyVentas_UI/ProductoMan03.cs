using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using ProyVentas_BE;
using ProyVentas_BL;

namespace ProyVentas_GUI
{
    public partial class ProductoMan03 : Form
    {
        private ProductoBL _productoBL = new ProductoBL();
        private ProductoBE _productoBE= new ProductoBE();
        private UnidadMedidaBL _unidadMedidaBL = new UnidadMedidaBL();
        private CategoriaBL _categoriaBL = new CategoriaBL();

        public string Codigo { get; set; }

        public ProductoMan03()
        {
            InitializeComponent();
        }

        private void ProductoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCategorias();
                CargarUnidadesMedida();
                CargarDatosProducto(Codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCategorias()
        {
            DataTable dtCategoria = _categoriaBL.ListarCategoria();
            DataRow drCategoria = dtCategoria.NewRow();
            drCategoria["Id_cat"] = 0;
            drCategoria["Des_cat"] = "-- Seleccione una categoría --"; // Texto más descriptivo
            dtCategoria.Rows.InsertAt(drCategoria, 0);

            cboCategoria.DataSource = dtCategoria;
            cboCategoria.ValueMember = "Id_cat";
            cboCategoria.DisplayMember = "Des_cat";
            EstilizarComboBox(cboCategoria); // Llamada a método para estilizar ComboBox
        }

        private void CargarUnidadesMedida()
        {
            DataTable dtUM = _unidadMedidaBL.ListarUM();
            DataRow drUM = dtUM.NewRow();
            drUM["Id_UM"] = 0;
            drUM["Des_UM"] = "-- Seleccione una unidad de medida --"; // Texto más descriptivo
            dtUM.Rows.InsertAt(drUM, 0);

            cboUM.DataSource = dtUM;
            cboUM.ValueMember = "Id_UM";
            cboUM.DisplayMember = "Des_UM";
            EstilizarComboBox(cboUM); // Llamada a método para estilizar ComboBox
        }

        private void EstilizarComboBox(ComboBox comboBox)
        {
            comboBox.BackColor = Color.White;
            comboBox.ForeColor = Color.Black;
            comboBox.Font = new Font("Arial", 10, FontStyle.Regular);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox.DrawItem += (s, e) =>
            {
                if (e.Index >= 0)
                {
                    e.DrawBackground();
                    e.DrawFocusRectangle();
                    e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
                }
            };
        }


        private void CargarDatosProducto(string codigo)
        {
            _productoBE = _productoBL.ConsultarProducto(codigo);

            lblCodigo.Text = _productoBE.Cod_pro;
            txtDescripcion.Text = _productoBE.Des_pro;
            txtPrecio.Text = _productoBE.Pre_pro.ToString(CultureInfo.InvariantCulture);
            txtStkAct.Text = _productoBE.Stk_act.ToString();
            txtStkMin.Text = _productoBE.Stk_min.ToString();

            cboCategoria.SelectedValue = _productoBE.Id_Cat;
            cboUM.SelectedValue = _productoBE.Id_UM;

            optImportado.Checked = _productoBE.Importado == 1;
            optNacional.Checked = _productoBE.Importado == 0;

            chkActivo.Checked = _productoBE.Est_pro == 1;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de grabar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ActualizarProductoBE();

                _productoBL.ActualizarProducto(_productoBE);

                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al grabar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarProductoBE()
        {
            _productoBE.Cod_pro = lblCodigo.Text;
            _productoBE.Des_pro = txtDescripcion.Text;
            _productoBE.Pre_pro = float.Parse(txtPrecio.Text, CultureInfo.InvariantCulture);
            _productoBE.Stk_act = short.Parse(txtStkAct.Text);
            _productoBE.Stk_min = short.Parse(txtStkMin.Text);
            _productoBE.Id_Cat = Convert.ToInt16(cboCategoria.SelectedValue);
            _productoBE.Id_UM = Convert.ToInt16(cboUM.SelectedValue);
            _productoBE.Importado = optImportado.Checked ? (short)1 : (short)0;
            _productoBE.Est_pro = chkActivo.Checked ? (short)1 : (short)0;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtStkAct.Text) ||
                string.IsNullOrWhiteSpace(txtStkMin.Text) ||
                cboCategoria.SelectedIndex == 0 ||
                cboUM.SelectedIndex == 0)
            {
                return false;
            }

            if (!float.TryParse(txtPrecio.Text, out float precio) || precio <= 0 ||
                !short.TryParse(txtStkAct.Text, out _) || !short.TryParse(txtStkMin.Text, out _))
            {
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = Thread.CurrentThread.CurrentCulture;
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
