//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.SqlClient;

//namespace ProyWinC_Sem04
//{
//    public partial class frmExecuteReader : Form
//    {
//        //Declaramos las instancias
        

//        public frmExecuteReader()
//        {
//            InitializeComponent();
//        }
       

//        private void btnListarProductos_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                // Codifique
//            }
//            catch (SqlException ex)
//            {
//                MessageBox.Show("Error: " + ex.Message);
//            }
//            finally
//            {
//                if (cnx.State == ConnectionState.Open )
//                {
//                    cnx.Close();

//                }

//            }


//        }

//        private void btnListarProveedores_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                // Codifique
//            }
//            catch (SqlException ex)
//            {
//                MessageBox.Show("Error: " + ex.Message);
//            }
//            finally
//            {
//                if (cnx.State == ConnectionState.Open)
//                {
//                    cnx.Close();

//                }

//            }
//        }
//    }
//}
