using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disconnected_mode
{
    internal class DatabaseLayer
    {
        static string connectionstring;
        static DatabaseLayer()
        {
            connectionstring = ConfigurationManager.ConnectionStrings["iti"].ConnectionString;

        }

       
        public static DataTable select(string command)
        {
           SqlDataAdapter Adapter = new SqlDataAdapter(command, connectionstring );
            DataTable dt = new DataTable();

            Adapter.Fill(dt);   

            return dt;
        }

        public static int getmaxid()
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand("select max(crs_id) from Course ", connection);
            // open connection
            connection.Open();
            // excute query
            var res = command.ExecuteScalar();
            int id = (int)res;

            connection.Close();
            return id;

        }

        public static int DMLcommand(string command)
        {
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand sqlcmd = new SqlCommand(command, connection);

            connection.Open();

            int res = sqlcmd.ExecuteNonQuery(); 

            connection.Close();
            return res;
            
        }


    }




}
