﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace W1T2BQ3
{
    public class Conexao
    {
        #region
        private static string Server = "localhost";
        private static string Database = "xxx";
        private static string User = "xxx";
        private static string Password = "xxxx";

        private static string connectionString = $@"Server={Server};
                                                    Database={Database};
                                                    Uid={User};
                                                    Pwd={Password};
                                                    SslMode=none;charset=utf8;";
        #endregion

        public static MySqlConnection Connection = new MySqlConnection(connectionString);

        public static void Conectar()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public static void Desconectar()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}