using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEAgenda
    {
        public string Codigo { get; private set; }
        public string Dni { get; private set; }
        public string Nombres { get; private set; }
        public string Direccion { get; private set; }
        public string Telefono { get; private set; }
        public string Fecha { get; private set; }
        public string Hora { get; private set; }
        public string Actividad { get; private set; }



        public static ClsEAgenda Save()
        {
            return new ClsEAgenda()
            {
              
            };
        }


        public void Update()
        {

        }

        public void Search()
        {

        }
        public void Delete()
        {

        }










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
