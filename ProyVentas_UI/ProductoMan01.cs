using ProyVentas_BL;
using System.Data;

namespace ProyVentas_GUI
{
    public partial class ProductoMan01 : Form
    {
        private ProductoBL _productoBL = new ProductoBL();
        private DataView _dtv;

        public ProductoMan01()
        {
            InitializeComponent();
        }

        private void ProductoMan01_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void CargarDatos(string filtro)
        {
            try
            {
                _dtv = new DataView(_productoBL.ListarProducto())
                {
                    RowFilter = $"des_pro LIKE '%{filtro}%'"
                };
                dtgDatos.DataSource = _dtv;
                lblRegistros.Text = dtgDatos.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var objMan02 = new ProductoMan02())
                {
                    objMan02.ShowDialog();
                    CargarDatos(txtFiltro.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatos.CurrentRow != null)
                {
                    // Verificar que el valor de la celda no sea nulo antes de convertirlo
                    if (dtgDatos.CurrentRow.Cells[0].Value != null)
                    {
                        ProductoMan03 objMan03 = new ProductoMan03();
                        objMan03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                        objMan03.ShowDialog();

                        // REFRESCAR DATAGRIDVIEW
                        CargarDatos(txtFiltro.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("El valor seleccionado es nulo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un producto para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
