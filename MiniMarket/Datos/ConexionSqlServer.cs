using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MiniMarket.Datos
{
    public class ConexionSqlServer
    {
        public static string conexion = @"Data Source=localhost;Initial Catalog=DB_MINIMARKET;User Id=sa;Password=yourStrong#Password;";

        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void Open()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        public static void Closed()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
