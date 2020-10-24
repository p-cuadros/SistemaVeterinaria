using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEMascota
    {
        public string Dni { get; private set; }
        public string Nombres { get; private set; }
        public string Especie { get; private set; }
        public string Raza { get; private set; }
        public string Peso { get; private set; }
        public string Sexo { get; private set; }
        public string Nacimiento { get; private set; }
        public string Estado { get; private set; }




        public static ClsEMascota Save()
        {
            return new ClsEMascota()
            {

            };
        }


        public void Update()
        {

        }

        public void Search()
        {

        }










        public Principal.FrmMascota FrmMascota
        {
            get => default(Principal.FrmMascota);
            set
            {
            }
        }

        internal Negocios.ClsNMascota ClsNMascota
        {
            get => default(Negocios.ClsNMascota);
            set
            {
            }
        }
    }
}
