using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace datamining
{
    class koneksi
    {
        public static MySqlConnection Getconn()
        {
            System.Data.SqlClient.SqlConnection conn = new
                    System.Data.SqlClient.SqlConnection();

            String constr = "server = localhost;" +
                            "database = algoritmabayes;" +
                            "username = root;" +
                            "password = ;";
            return new MySqlConnection(constr);
        }
        
    }
}
