using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEHistorial
    {
        public string Dni { get; private set; }
        public string Nombres { get; private set; }

        public string Direccion { get; private set; }
        public string Telefono { get; private set; }



        public static ClsEHistorial Save()
        {
            return new ClsEHistorial()
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











        public Principal.FrmHistorial FrmHistorial
        {
            get => default(Principal.FrmHistorial);
            set
            {
            }
        }

        internal Negocios.ClsNHistorial ClsNHistorial
        {
            get => default(Negocios.ClsNHistorial);
            set
            {
            }
        }

        public Principal.FrmHistorial FrmHistorial1
        {
            get => default(Principal.FrmHistorial);
            set
            {
            }
        }
    }
}
