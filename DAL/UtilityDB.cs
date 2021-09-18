using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab1_ASPNetConnectedMode.DAL
{
    public class UtilityDB
    {
        //Version 1: Working but not good.Why? Another better solution?
        /// <summary>
        /// This method returns an active database connection
        /// </summary>
        /// <returns>object of type SqlConnection</returns>
        //public static SqlConnection ConnectDB()
        //{
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = "server=DESKTOP-DJ36JQQ\SQLEXPRESS;database=dbo;user=sa;password=1234;";
        //    conn.Open();
        //    return conn;
        //}

        //Version 2: better, more secure
        public static SqlConnection ConnectDB()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["dbo"].ConnectionString;
            conn.Open();
            return conn;
        }
    }
}