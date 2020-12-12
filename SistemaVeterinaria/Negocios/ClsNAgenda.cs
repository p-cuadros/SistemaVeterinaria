﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using SistemaVeterinaria.Entidades;
using SistemaVeterinaria.Principal;
namespace SistemaVeterinaria.Negocios
{
public  class ClsNAgenda
    {
        public FrmAgenda FrmAgenda
        {
            get => default(FrmAgenda);
            set
            {
            }
        }

        public static DataTable MtdListarTodo()
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_ListarAgenda";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }
        public static int sumar(int a, int b)
        {
            return a + b;
        }

        public static Boolean MtdAgregarMySql(ClsEAgenda clsCar)
        {
            try
            {
                ClsNConexion Objconexion = new ClsNConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "VetUSP_I_AgregarAgenda";
                Objcomando.CommandType = CommandType.StoredProcedure;

                Objcomando.Parameters.Add(new MySqlParameter("pdnireg", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnomreg", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pdirreg", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("ptelreg", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pfecreg", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("phorreg", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pactreg", MySqlDbType.VarChar));



                Objcomando.Parameters["pdnireg"].Value = clsCar.Dni;
                Objcomando.Parameters["pnomreg"].Value = clsCar.Nombres;
                Objcomando.Parameters["pdirreg"].Value = clsCar.Direccion;
                Objcomando.Parameters["ptelreg"].Value = clsCar.Telefono;
                Objcomando.Parameters["pfecreg"].Value = clsCar.Fecha;
                Objcomando.Parameters["phorreg"].Value = clsCar.Hora;
                Objcomando.Parameters["pactreg"].Value = clsCar.Actividad;

                Objcomando.Connection = Objconexion.conectar();
                Objcomando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }



        public static Boolean MtdMoficarMySql(ClsEAgenda clsCar)
        {
            try
            {
                ClsNConexion Objconexion = new ClsNConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "VetUSP_U_ActualizarAgenda";
                Objcomando.CommandType = CommandType.StoredProcedure;

                Objcomando.Parameters.Add(new MySqlParameter("pcodreg", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pdnireg", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnomreg", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pdirreg", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("ptelreg", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pfecreg", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("phorreg", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pactreg", MySqlDbType.VarChar));


                Objcomando.Parameters["pcodreg"].Value = clsCar.Codigo;
                Objcomando.Parameters["pdnireg"].Value = clsCar.Dni;
                Objcomando.Parameters["pnomreg"].Value = clsCar.Nombres;
                Objcomando.Parameters["pdirreg"].Value = clsCar.Direccion;
                Objcomando.Parameters["ptelreg"].Value = clsCar.Telefono;
                Objcomando.Parameters["pfecreg"].Value = clsCar.Fecha;
                Objcomando.Parameters["phorreg"].Value = clsCar.Hora;
                Objcomando.Parameters["pactreg"].Value = clsCar.Actividad;

                Objcomando.Connection = Objconexion.conectar();
                Objcomando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public static DataTable MtdBuscarMySql(ClsEAgenda clsCar)
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_BuscarAgenda";
            command.Parameters.Add(new MySqlParameter("pfecreg", MySqlDbType.VarChar));
            command.Parameters["pfecreg"].Value = clsCar.Fecha;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }
    }
}
