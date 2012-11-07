using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace PropertyView
{
    public class DataConnection
    {
        private const String connectionString = "Server=scarecrowserver.dyndns-free.com;Port=3306;Database=adream;Uid=root;Pwd=root";

        public DataTable ExecuteQuery(String sSQL)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sSQL;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();
            return dt;
        }

        public int ExecuteNonQuery(String sSQL)
        {
            MySqlConnection conn;
            MySqlCommand cmd;
            int rowsAffected;
            String str;

            conn = new MySqlConnection(connectionString);

            cmd = new MySqlCommand();
            cmd.CommandText = sSQL;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            try
            {
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }

            catch (Exception exc)
            {
                rowsAffected = -1;
                str = exc.Message;
                throw new Exception("MySQL : " + str);
            }
            conn.Close();
            return rowsAffected;
        }
    }
}
