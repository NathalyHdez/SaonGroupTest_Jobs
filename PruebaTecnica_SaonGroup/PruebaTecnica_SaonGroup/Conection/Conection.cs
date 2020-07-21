using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using System.Data;
using System.Reflection;


namespace PruebaTecnica_SaonGroup.Conection
{
    public class Conection
    {
        public SQLiteConnection crearConexionSql() {
            SQLiteConnection conexion;

            // Ruta - Sql Lite
            string ruta = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/SaonGroupTestDB.db");             
            string fuente = String.Format(@"Data Source={0};Version={1}", ruta, 3);

            conexion = new SQLiteConnection(fuente, true);
            //Abriendo conexion
            conexion.Open();
            return conexion;

        }

        public DataSet EjecutarConsultas(string SqlQuery) {

            DataSet ds = new DataSet();
            SQLiteConnection conexion = new SQLiteConnection();

            SQLiteDataReader Lector;
            SQLiteCommand Comando;
            


            try {
                conexion = crearConexionSql();

                Comando = conexion.CreateCommand();
                Comando.CommandText = SqlQuery;
                Lector = Comando.ExecuteReader();

                ds.Tables.Add("DataTableSQL");
                ds.Tables[0].Load(Lector);
                //while (Lector.Read())
                //{
                //    string myreader = Lector.GetString(0);
                //    Console.WriteLine(myreader);
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally {
                conexion.Close();
            }


            return ds;
        }

    }
}