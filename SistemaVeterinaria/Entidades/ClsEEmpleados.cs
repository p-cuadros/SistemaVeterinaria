using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEEmpleados
    {
        public string Codigo { get; private set; }
        public string Nombre { get; private set; }
        public string Apellidos { get; private set; }
        public string Direccion { get; private set; }
        public string Email { get; private set; }
        public string Cargo { get; private set; }
        public string Clave { get; private set; }
        public string Estado { get;private set; }


        public static ClsEEmpleados Save()
        {
            return new ClsEEmpleados()
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

















        public Principal.FrmEmpleado FrmEmpleado
        {
            get => default(Principal.FrmEmpleado);
            set
            {
            }
        }

        internal Negocios.ClsNEmpleados ClsNEmpleados
        {
            get => default(Negocios.ClsNEmpleados);
            set
            {
            }
        }
    }
}
