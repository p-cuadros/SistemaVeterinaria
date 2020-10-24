using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEMantenimientos
    {
        public string Dni { get; private set; }
        public string Nombre { get; private  set; }
      
        public string Tipo { get; private set; }
        public string Detalle { get; private set; }
        public string Fecha { get; private set; }
        public string Precio { get; private set; }


        public static ClsEMantenimientos Save()
        {
            return new ClsEMantenimientos()
            {

            };
        }


        public void Update()
        {

        }

        public void Search()
        {

        }









        public Principal.FrmMantenimiento FrmMantenimiento
        {
            get => default(Principal.FrmMantenimiento);
            set
            {
            }
        }

        internal Negocios.ClsNMantenimiento ClsNMantenimiento
        {
            get => default(Negocios.ClsNMantenimiento);
            set
            {
            }
        }
    }
}
