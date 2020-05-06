using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Saucer_Data
    {
        Connection conn = new Connection();

        public List<Saucer> getSaucers()
        {
            List<Saucer> saucers = new List<Saucer>();

            try
            {
                conn.open();
                SqlCommand cmd = new SqlCommand("getSaucers", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Saucer saucer = new Saucer();
                    saucer.idSaucer = Convert.ToInt32(reader["Identificador"]);
                    saucer.nameSaucer = reader["Nombre"].ToString();
                    saucer.costSaucer = float.Parse(reader["Costo"].ToString());

                    saucers.Add(saucer);
                }

                conn.close();
            }
            catch (Exception)
            {
                throw;
            }

            return saucers;
        }
    }
}
