using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEGanancias
    {
        public string FechaI { get; private set; }
        public string FechaF { get; private set; }
        public string PrecioTotalV { get; private set; }
        public string PrecioTotalM { get; private set; }
        public string PrecioTotalT { get; private set; }


        public static ClsEGanancias Save()
        {
            return new ClsEGanancias()
            {

            };
        }


        public void Update()
        {

        }

        public void Search()
        {

        }
     




        public Principal.FrmGanancias FrmGanancias
        {
            get => default(Principal.FrmGanancias);
            set
            {
            }
        }

        internal Negocios.ClsNGanancias ClsNGanancias
        {
            get => default(Negocios.ClsNGanancias);
            set
            {
            }
        }
    }
}
