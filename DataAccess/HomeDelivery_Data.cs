using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HomeDelivery_Data
    {
        Connection conn = new Connection();

        public bool InsertHomeDelivery(int id)
        {
            bool response = false;

            try
            {
                conn.open();
                SqlCommand cmd = new SqlCommand("addHomeDiliveries", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p_idClient = new SqlParameter();
                p_idClient.ParameterName = "@fkIdClient";
                p_idClient.SqlDbType = SqlDbType.Int;
                p_idClient.Value = id;

                cmd.Parameters.Add(p_idClient);

                cmd.ExecuteNonQuery();
                response = true;

                conn.close();
            }
            catch (Exception e)
            {
                throw;
            }

            return response;
        }
    }
}
