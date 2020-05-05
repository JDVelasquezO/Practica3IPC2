using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Client_Data
    {
        Connection conn = new Connection();

        public List<Client> getClient()
        {
            List<Client> list = new List<Client>();

            try
            {
                conn.open();
                
                SqlCommand cmd;
                SqlDataReader reader;

                cmd = new SqlCommand("SELECT * FROM client", conn.returnConn());
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Client client = new Client();
                    client.id_client = Convert.ToInt32(reader["cui"].ToString());
                    client.first_client = reader["first_name"].ToString();
                    client.last_client = reader["last_name"].ToString();
                    client.phone = reader["phone"].ToString();
                    client.nit_client = Convert.ToInt32(reader["nit"].ToString());
                    client.address = reader["address"].ToString();
                    
                    list.Add(client);
                }

                conn.close();
            }
            catch (Exception)
            {
                throw;
            }

            return list;
        }
    }
}
