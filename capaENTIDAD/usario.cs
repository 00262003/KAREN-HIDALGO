﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaENTIDAD
{
    public class usario
    {
        public int idUSARIO { get; set; }
        public string documento { get; set; }
        public string nombreCompleto { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public  rol  orol { get; set; }
        public bool estado { get; set; }
        public string fechadecreacion { get; set; }
    }
}
