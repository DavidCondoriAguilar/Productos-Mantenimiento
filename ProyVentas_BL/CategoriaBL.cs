using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar
using ProyVentas_ADO;
namespace ProyVentas_BL
{
    public  class CategoriaBL
    {
        CategoriaADO objCategoriaADO = new CategoriaADO();

        public DataTable ListarCategoria()
        {
            return objCategoriaADO.ListarCategoria();
        }

    }
}
