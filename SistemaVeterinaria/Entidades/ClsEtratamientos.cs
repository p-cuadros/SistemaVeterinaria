﻿using System;
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



        public static ClsEtratamientos Save(string _dni, string _nombre, string _tratamientos,string _detalle, string _receta, string _fecha, string _cita,string _precio)
        {
            return new ClsEtratamientos()
            {
                Dni = _dni,
                Nombre = _nombre,
                Tratamientos = _tratamientos,
                Detalle = _detalle,
                Receta = _receta,
                Fecha = _fecha,
                Cita = _cita,
                Precio = _precio
            };
        }
        //public void ModificarNombre(string _nombre)
        //{
        //    NombreCliente = _nombre;
        //}     
        public void Update(string _dni, string _nombre, string _tratamientos, string _detalle, string _receta, string _fecha, string _cita, string _precio)
        {
            Dni = _dni;
            Nombre = _nombre;
            Tratamientos = _tratamientos;
            Detalle = _detalle;
            Receta = _receta;
            Fecha = _fecha;
            Cita = _cita;
            Precio = _precio;
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
