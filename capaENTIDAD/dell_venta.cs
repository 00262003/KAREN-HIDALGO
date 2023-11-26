using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaENTIDAD
{
    public class dell_venta
    {
        public int idDELL_VENTA { get; set; }
        public venta1 oventa1 {get; set; }
        public producto2 oproducto2 { get; set; }
        public decimal precioV { get; set; }
        public int cantidad{ get; set; }
        public decimal subtotal { get; set; }
        public string fechadecreacion { get; set; }
    }
}
 