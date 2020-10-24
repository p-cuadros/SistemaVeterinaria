using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEServicios
    {
        public string Dni { get; private set; }
        public string Nombres { get;private  set; }
      
        public string Vacuna { get; private set; }
        public string Detalle { get; private set; }
        public string Fecha { get; private set; }
        public string Precio { get; private set; }





        public static ClsEServicios Save()
        {
            return new ClsEServicios()
            {

            };
        }


        public void Update()
        {

        }

        public void Search()
        {

        }















        public Principal.FrmServicios FrmServicios
        {
            get => default(Principal.FrmServicios);
            set
            {
            }
        }
    }
}
