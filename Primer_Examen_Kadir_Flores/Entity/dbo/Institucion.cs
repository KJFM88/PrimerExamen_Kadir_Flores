﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Institucion: DBEntity
    {
        public int Id_Intitucion { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public int Estado { get; set; }
    }
}
