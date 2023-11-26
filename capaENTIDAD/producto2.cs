using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaENTIDAD
{
    public class producto2
    {
        public int idPRODUCTO { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public categoria_ ocateoria { get; set; }
        public int stock { get; set; }
        public decimal precioC { get; set; }
        public decimal precioV { get; set; }
        public bool estado { get; set; }
        public string fechadecreacion { get; set; }
  
    }
}
