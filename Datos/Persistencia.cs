using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Datos
{
    public class Persistencia
    {
        MySqlConnection connection = new MySqlConnection(
                                        ConfigurationManager.ConnectionStrings["CuerosColombia"].ConnectionString);

        public MySqlConnection conexion()
        {
            try
            {
                connection.Open();
                System.Diagnostics.Debug.WriteLine("EXITO");
                return connection;
            }
            catch (Exception e)
            {
                e.ToString();
                System.Diagnostics.Debug.WriteLine("MALO");
                return null;
            }
        }


        //Metodo para cerrar la conexion
        public void cerrarConexion()
        {
            connection.Close();
        }

        //Metodo que permite manipular los datos (INSERT, SELECT, UPDATE, DELETE)
        public bool ejecutarDML(String sql)
        {
            bool ejecuto = false;
            connection.Open();
            return ejecuto;
        }

        public DataSet ejecutarConsulta(String sql)
        {
            DataSet datos = new DataSet();
            connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
            dataAdapter.Fill(datos);
            connection.Close();
            return datos;
        }
    }
}