using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Connection
    {
        string stringConn = "Data Source=localhost;Initial Catalog=practica1;Integrated Security=True";
        public SqlConnection conn = new SqlConnection();

        public Connection()
        {
            conn.ConnectionString = stringConn;
        }

        public void open()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void close()
        {
            conn.Close();
        }

        public SqlConnection returnConn()
        {
            return conn;
        }
    }
}
