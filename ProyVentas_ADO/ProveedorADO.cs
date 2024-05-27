using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ProyVentas_BE;
namespace ProyVentas_ADO
{
    public class ProveedorADO
    {
        // Insumos.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        // Metodos de mantenimiento
        public Boolean InsertarProveedor(ProveedorBE objProveedorBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarProveedor";

                // Agregamos parametros
                cmd.Parameters.AddWithValue("@Cod_prv", objProveedorBE.Cod_prv);
                cmd.Parameters.AddWithValue("@Raz_soc_prv", objProveedorBE.Raz_soc_prv);
                cmd.Parameters.AddWithValue("@Dir_prv", objProveedorBE.Dir_prv);
                cmd.Parameters.AddWithValue("@Tel_prv", objProveedorBE.Tel_prv);
                cmd.Parameters.AddWithValue("@Ruc_prv", objProveedorBE.Ruc_prv);
                cmd.Parameters.AddWithValue("@Rep_ven", objProveedorBE.Rep_ven);
                cmd.Parameters.AddWithValue("@Id_Ubigeo", objProveedorBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@Usu_Registro", objProveedorBE.Usu_Registro);
                cmd.Parameters.AddWithValue("@Est_prv", objProveedorBE.Est_prv);
                cmd.Parameters.AddWithValue("@Fec_Registro", objProveedorBE.Fec_Registro);
                cmd.Parameters.AddWithValue("@Fec_Ult_Mod", objProveedorBE.Fec_Ult_Mod);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objProveedorBE.Usu_Ult_Mod);

                // Abrimos la conexión y ejecutamos el comando
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }


        public Boolean ActualizarProveedor(ProveedorBE objProveedorBE)
        {
            
            try
            {
             cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarProveedor";
                //Agregamos parametros 
                //Codifique


                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
               
            }
           

        }

        public Boolean EliminarProveedor(String strCod)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarProveedor";

                // Agregamos parametros
                cmd.Parameters.AddWithValue("@Cod_prv", strCod);

                // Abrimos la conexión y ejecutamos el comando
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }


        public ProveedorBE ConsultarProveedor(String strCod)
        {
            try
            {
                ProveedorBE objProveedorBE = new ProveedorBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProveedor";

                // Agregamos parametros
                cmd.Parameters.AddWithValue("@Cod_prv", strCod);

                // Abrimos la conexión y ejecutamos el comando
                cnx.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    objProveedorBE.Cod_prv = reader["Cod_prv"].ToString();
                    objProveedorBE.Raz_soc_prv = reader["Raz_soc_prv"].ToString();
                    objProveedorBE.Dir_prv = reader["Dir_prv"].ToString();
                    objProveedorBE.Tel_prv = reader["Tel_prv"].ToString();
                    objProveedorBE.Ruc_prv = reader["Ruc_prv"].ToString();
                    objProveedorBE.Rep_ven = reader["Rep_ven"].ToString();
                    objProveedorBE.Id_Ubigeo = reader["Id_Ubigeo"].ToString();
                    objProveedorBE.Fec_Registro = Convert.ToDateTime(reader["Fec_Registro"]);
                    objProveedorBE.Usu_Registro = reader["Usu_Registro"].ToString();
                    objProveedorBE.Fec_Ult_Mod = Convert.ToDateTime(reader["Fec_Ult_Mod"]);
                    objProveedorBE.Usu_Ult_Mod = reader["Usu_Ult_Mod"].ToString();
                    objProveedorBE.Est_prv = Convert.ToInt16(reader["Est_prv"]);
                }

                reader.Close();
                return objProveedorBE;
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


        public DataTable ListarProveedor()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProveedor";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Proveedores");
                return dts.Tables["Proveedores"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }




    }
}
