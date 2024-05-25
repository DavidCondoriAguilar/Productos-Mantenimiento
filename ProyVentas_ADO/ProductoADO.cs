using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar....
using System.Data;
using System.Data.SqlClient;
using ProyVentas_BE;
namespace ProyVentas_ADO
{
    public  class ProductoADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;





        public DataTable ListarProducto()
        {
            DataTable dtProductos = new DataTable();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProducto";
                cnx.Open();
                dtr = cmd.ExecuteReader();
                dtProductos.Load(dtr);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            return dtProductos;
        }



        public ProductoBE ConsultarProducto(string strCodigo)
        {
            ProductoBE producto = null;
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strCodigo);
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    producto = new ProductoBE
                    {
                        Cod_pro = dtr["Cod_pro"].ToString(),
                        Des_pro = dtr["Des_pro"].ToString(),
                        Pre_pro = Convert.ToSingle(dtr["Pre_pro"]),
                        Stk_act = Convert.ToInt16(dtr["Stk_act"]),
                        Stk_min = Convert.ToInt16(dtr["Stk_min"]),
                        Id_UM = Convert.ToInt16(dtr["Id_UM"]),
                        Id_Cat = Convert.ToInt16(dtr["Id_Cat"]),
                        Importado = Convert.ToInt16(dtr["Importado"]),
                        Fec_Registro = Convert.ToDateTime(dtr["Fec_Registro"]),
                        Usu_Registro = dtr["Usu_Registro"].ToString(),
                        Fec_Ult_Mod = Convert.ToDateTime(dtr["Fec_Ult_Mod"]),
                        Usu_Ult_Mod = dtr["Usu_Ult_Mod"].ToString(),
                        Est_pro = Convert.ToInt16(dtr["Est_pro"])
                    };
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            return producto;
        }




        public bool InsertarProducto(ProductoBE objProductoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vdes", objProductoBE.Des_pro); // Parámetro para el procedimiento almacenado
                cmd.Parameters.AddWithValue("@vpre", objProductoBE.Pre_pro); // Parámetro para el procedimiento almacenado
                cmd.Parameters.AddWithValue("@vstka", objProductoBE.Stk_act); // Parámetro para el procedimiento almacenado
                cmd.Parameters.AddWithValue("@vstkm", objProductoBE.Stk_min); // Parámetro para el procedimiento almacenado
                cmd.Parameters.AddWithValue("@vId_UM", objProductoBE.Id_UM); // Parámetro para el procedimiento almacenado
                cmd.Parameters.AddWithValue("@vId_Cat", objProductoBE.Id_Cat); // Parámetro para el procedimiento almacenado
                cmd.Parameters.AddWithValue("@vimp", objProductoBE.Importado); // Parámetro para el procedimiento almacenado
                cmd.Parameters.AddWithValue("@vUsu_Registro", objProductoBE.Usu_Registro); // Parámetro para el procedimiento almacenado
                cmd.Parameters.AddWithValue("@vEst_pro", objProductoBE.Est_pro); // Parámetro para el procedimiento almacenado
                cnx.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }




        public bool ActualizarProducto(ProductoBE objProductoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarProducto";
                cmd.Parameters.Clear(); // Limpiar parámetros previos

                // Agregar parámetros
                cmd.Parameters.AddWithValue("@vcod", objProductoBE.Cod_pro);
                cmd.Parameters.AddWithValue("@vdes", objProductoBE.Des_pro);
                cmd.Parameters.AddWithValue("@vpre", objProductoBE.Pre_pro);
                cmd.Parameters.AddWithValue("@vstka", objProductoBE.Stk_act);
                cmd.Parameters.AddWithValue("@vstkm", objProductoBE.Stk_min);
                cmd.Parameters.AddWithValue("@vId_UM", objProductoBE.Id_UM);
                cmd.Parameters.AddWithValue("@vId_Cat", objProductoBE.Id_Cat);
                cmd.Parameters.AddWithValue("@vimp", objProductoBE.Importado);
                cmd.Parameters.AddWithValue("@vUsu_ult_mod", objProductoBE.Usu_Ult_Mod);
                cmd.Parameters.AddWithValue("@vest_pro", objProductoBE.Est_pro);

                cnx.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }


        public bool EliminarProducto(string strCodigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarProducto";
                cmd.Parameters.Clear(); // Limpiar parámetros previos

                // Agregar parámetro
                cmd.Parameters.AddWithValue("@vcod", strCodigo);

                cnx.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }



    }
}
