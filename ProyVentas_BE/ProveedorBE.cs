using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyVentas_BE
{
  public  class ProveedorBE
    {
        
        public String Cod_prv { get; set; }
       
        public String Raz_soc_prv { get; set; }
        
        public String Dir_prv { get; set; }
       
        public String Tel_prv { get; set; }
       
        public String Ruc_prv { get; set; }        
       
        public String Rep_ven { get; set; }
      
        public String Id_Ubigeo { get; set; }

        public DateTime Fec_Registro { get; set; }
       
        public String Usu_Registro { get; set; }
       
        public DateTime Fec_Ult_Mod { get; set; }
       
        public String Usu_Ult_Mod { get; set; }
              
        public Int16 Est_prv { get; set; }
        
    }
}
