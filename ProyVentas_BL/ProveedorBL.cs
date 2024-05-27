using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Agregamos los using...
using System.Data;
using ProyVentas_ADO;
using ProyVentas_BE;

namespace ProyVentas_BL
{
    public class ProveedorBL
    {
        ProveedorADO objProveedorADO = new ProveedorADO();

        public Boolean InsertarProveedor(ProveedorBE objProveedorBE)
        {
            return objProveedorADO.InsertarProveedor(objProveedorBE);
        }
        public Boolean ActualizarProveedor(ProveedorBE objProveedorBE)
        {
            return objProveedorADO.ActualizarProveedor(objProveedorBE);
        }
        public Boolean EliminarProveedor(String strcod)
        {
            return objProveedorADO.EliminarProveedor(strcod);
        }

        public ProveedorBE ConsultarProveedor(String strcod)
        {
            return objProveedorADO.ConsultarProveedor(strcod);
        }

        public DataTable ListarProveedor()
        {
            return objProveedorADO.ListarProveedor();
        }

        



    }
}
