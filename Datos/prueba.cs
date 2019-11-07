using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class prueba
    {
        Persistencia p = new Persistencia();

        public bool insertar(string nombre)
        {
             
            bool ejecuto = false;
            int filas = 0;

            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = p.conexion();
            mySqlCommand.CommandText = "INSERT INTO prueba (nombre) VALUES ('" + nombre + "')";
            mySqlCommand.CommandType = System.Data.CommandType.Text;

            try
            {
                filas = mySqlCommand.ExecuteNonQuery();
                if (filas > 0)
                {
                    ejecuto = true;
                }
            }
            catch (Exception e)
            {

                ejecuto.ToString();
            }
            p.cerrarConexion();
            return ejecuto;
        }

        public void insertarCSV(string namecsv)
        {
            MySqlBulkLoader mySqlBulkLoader = new MySqlBulkLoader(p.conexion());
            mySqlBulkLoader.TableName = "prueba";
            mySqlBulkLoader.FileName = namecsv;
            mySqlBulkLoader.FieldTerminator = ",";
            mySqlBulkLoader.FieldQuotationCharacter = '"';
            mySqlBulkLoader.Load();
        }
    }
}