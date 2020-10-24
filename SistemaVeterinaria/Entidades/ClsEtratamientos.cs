using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEtratamientos
    {
        public string Dni { get; private set; }
        public string Nombre { get; private set; }
        public string Tratamientos { get; private set; }
        public string  Detalle{ get; private set; }
        public string Receta { get; private set; }
        public string Fecha { get;private  set; }
        public string Cita { get; private set; }
        public string Precio { get; private set; }



        public static ClsEtratamientos Save()
        {
            return new ClsEtratamientos()
            {

            };
        }


        public void Update()
        {

        }

        public void Search()
        {

        }














        internal Negocios.ClsNTratamientos ClsNTratamientos
        {
            get => default(Negocios.ClsNTratamientos);
            set
            {
            }
        }

        public Principal.FrmTratamientos FrmTratamientos
        {
            get => default(Principal.FrmTratamientos);
            set
            {
            }
        }
    }
}
