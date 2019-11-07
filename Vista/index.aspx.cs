using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace Vista
{
    public partial class index : System.Web.UI.Page
    {
        Persistencia persistencia = new Persistencia();
        prueba prueba = new prueba();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // prueba.insertar("Jorge");
                correoCSV();
            }
        }

        public void correoCSV()
        {
            string cvsCamino = @"F:\Practicas C#\Siigo\Vista\Recursos\csv\customer2.csv";
            //Create a DataTable.
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[3] {
                    new DataColumn("ids", typeof(int)),
                    new DataColumn("nombre", typeof(string)),
                    new DataColumn("apellido", typeof(string))
                    });

            //Read the contents of CSV file.
            string csvData = File.ReadAllText(cvsCamino);

            prueba.insertarCSV(cvsCamino);
            //Execute a loop over the rows.
            foreach (string row in csvData.Split('\n'))
            {
                //System.Diagnostics.Debug.WriteLine("-> " + row[1]);

                if (!string.IsNullOrEmpty(row))
                {

                    dt.Rows.Add();
                    int i = 0;

                    //Execute a loop over the columns.
                    foreach (string cell in row.Split(','))
                    {

                        dt.Rows[dt.Rows.Count - 1][i] = cell;
                        i++;
                    }

                }
            }

            //Bind the DataTable.
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}