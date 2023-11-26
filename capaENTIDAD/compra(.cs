using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaENTIDAD
{
    public class compra_
    {
        public int idCOMPRA { get; set; }
        public usario ousario { get; set; }
        public proveedor oproveedor{ get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public decimal total { get; set; }
        public string fechadecreacion { get; set; }
    }
}
