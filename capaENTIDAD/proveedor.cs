using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaENTIDAD
{
    public class proveedor
    {
        public int idPROVEEDOR { get; set; }
        public string documento { get; set; }
        public string razonsocial { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public bool estado { get; set; }
        public string fechadecreacion { get; set; }
    }
}
