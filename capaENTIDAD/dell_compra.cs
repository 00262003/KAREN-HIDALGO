using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaENTIDAD
{
    internal class dell_compra
    {
        public int idDELL_COMPRA { get; set; }
        public compra_ ocompra { get; set; }
        public producto2 oproducto { get; set; }
        public decimal precioC { get; set; }
        public decimal precioV { get; set; }
        public int cantidad { get; set; }
        public decimal total { get; set; }
        public List<dell_compra> odell_Compras { get; set; }
        public string fechadecreacion { get; set; }
    }
}
