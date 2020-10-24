﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEAgenda
    {
        public string Codigo { get; set; }
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Actividad { get; set; }

        internal Negocios.ClsNAgenda ClsNAgenda
        {
            get => default(Negocios.ClsNAgenda);
            set
            {
            }
        }

        public Principal.FrmAgenda FrmAgenda
        {
            get => default(Principal.FrmAgenda);
            set
            {
            }
        }
    }
}
