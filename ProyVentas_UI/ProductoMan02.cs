using System;
using System.Data;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyVentas_BE;
using ProyVentas_BL;

namespace ProyVentas_GUI
{
    public partial class ProductoMan02 : Form
    {
        private readonly ProductoBL _productoBL = new ProductoBL();
        private readonly ProductoBE _productoBE = new ProductoBE();
        private readonly UnidadMedidaBL _unidadMedidaBL = new UnidadMedidaBL();
        private readonly CategoriaBL _categoriaBL = new CategoriaBL();

        private bool _isSaving = false;

        public ProductoMan02()
        {
            InitializeComponent();
            // Suscribimos el evento aquí
            btnGrabar.Click += async (sender, e) => await BtnGrabar_Click(sender, e);
        }

        private async void ProductoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                await CargarCategoriasAsync();
                await CargarUnidadesMedidaAsync();
            }
            catch (Exception ex)
            {
                MostrarMensajeError("Error al cargar datos: " + ex.Message);
            }
        }

        private async Task CargarCategoriasAsync()
        {
            DataTable dt = await Task.Run(() => _categoriaBL.ListarCategoria());
            if (dt == null) throw new DataException("No se pudieron cargar las categorías.");

            DataRow dr = dt.NewRow();
            dr["Id_Cat"] = 0;
            dr["Des_cat"] = "--Seleccione---";
            dt.Rows.InsertAt(dr, 0);

            cboCategoria.DataSource = dt;
            cboCategoria.ValueMember = "Id_Cat";
            cboCategoria.DisplayMember = "Des_cat";
        }

        private async Task CargarUnidadesMedidaAsync()
        {
            DataTable dt = await Task.Run(() => _unidadMedidaBL.ListarUM());
            if (dt == null) throw new DataException("No se pudieron cargar las unidades de medida.");

            DataRow dr = dt.NewRow();
            dr["Id_UM"] = 0;
            dr["Des_UM"] = "--Seleccione---";
            dt.Rows.InsertAt(dr, 0);

            cboUM.DataSource = dt;
            cboUM.ValueMember = "Id_UM";
            cboUM.DisplayMember = "Des_UM";
        }

        private async Task BtnGrabar_Click(object sender, EventArgs e)
        {
            if (_isSaving)
            {
                MostrarMensajeAdvertencia("El producto ya se está guardando, por favor espere.");
                return;
            }

            try
            {
                _isSaving = true;
                btnGrabar.Enabled = false;

                if (!ValidarCampos())
                {
                    MostrarMensajeAdvertencia("Todos los campos son requeridos y deben tener valores válidos.");
                    return;
                }

                AsignarValoresProducto();

                bool resultado = await Task.Run(() => _productoBL.InsertarProducto(_productoBE));

                if (resultado)
                {
                    MostrarMensajeExito("Producto grabado correctamente.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    throw new InvalidOperationException("El registro no se insertó, contacte con TI.");
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeError("Error: " + ex.Message);
            }
            finally
            {
                _isSaving = false;
                btnGrabar.Enabled = true;
            }
        }

        private bool ValidarCampos()
        {
            // Validar campos vacíos
            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()) ||
                string.IsNullOrEmpty(txtPrecio.Text.Trim()) ||
                string.IsNullOrEmpty(txtStkAct.Text.Trim()) ||
                string.IsNullOrEmpty(txtStkMin.Text.Trim()) ||
                cboUM.SelectedIndex <= 0 ||
                cboCategoria.SelectedIndex <= 0 ||
                (!optImportado.Checked && !optNacional.Checked))
            {
                return false;
            }

            // Validar que el precio sea un número válido
            if (!float.TryParse(txtPrecio.Text.Trim(), out float precio) || precio <= 0)
            {
                return false;
            }

            // Validar que los stocks sean números válidos
            if (!short.TryParse(txtStkAct.Text.Trim(), out short stkAct) || stkAct < 0 ||
                !short.TryParse(txtStkMin.Text.Trim(), out short stkMin) || stkMin < 0)
            {
                return false;
            }

            return true;
        }

        private void AsignarValoresProducto()
        {
            _productoBE.Des_pro = txtDescripcion.Text.Trim();
            _productoBE.Pre_pro = Convert.ToSingle(txtPrecio.Text);
            _productoBE.Stk_act = Convert.ToInt16(txtStkAct.Text);
            _productoBE.Stk_min = Convert.ToInt16(txtStkMin.Text);
            _productoBE.Id_Cat = Convert.ToInt16(cboCategoria.SelectedValue);
            _productoBE.Id_UM = Convert.ToInt16(cboUM.SelectedValue);
            _productoBE.Importado = (short)(optImportado.Checked ? 1 : 0);
            _productoBE.Est_pro = (short)(chkActivo.Checked ? 1 : 0);
            _productoBE.Usu_Registro = "JLEON";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = CultureInfo.CurrentCulture;
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator);
        }

        private void txtStkAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void MostrarMensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MostrarMensajeExito(string mensaje)
        {
            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
