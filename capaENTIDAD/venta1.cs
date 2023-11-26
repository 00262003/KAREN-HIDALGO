using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaENTIDAD
{
    public class venta1
    {
        public int idVENTA { get; set; }
        public usario ousario { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public string DocumentoCliente { get; set; }
        public string nombreCliente { get; set; }
        public decimal totalPago { get; set; }
        public decimal totalCambio { get; set; }
        public decimal total { get; set; }
        public List<dell_venta> odell_Ventas { get; set; }
        public string fechadecreacion{ get; set; }
    }
}
