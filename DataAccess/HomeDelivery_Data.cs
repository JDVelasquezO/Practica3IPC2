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

        public bool InsertHomeDelivery(int id, List<int> idSaucers)
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

                int idHomeDelivery = getLastIDHomeDelivery();
                insertHomeDelivery_Saucers(idHomeDelivery, idSaucers);
            }
            catch (Exception e)
            {
                throw;
            }

            return response;
        }

        public int getLastIDHomeDelivery()
        {
            int idHomeDelivery = 0;

            try
            {
                conn.open();

                SqlCommand cmd;
                SqlDataReader reader;

                cmd = new SqlCommand("getIDHomeDelivery", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    idHomeDelivery = Convert.ToInt32(reader["id_home_delivery"].ToString());
                }

                conn.close();
            }
            catch (Exception)
            {
                throw;
            }

            return idHomeDelivery;
        }

        public bool insertHomeDelivery_Saucers(int idHomeDelivery, List<int> idSaucers)
        {
            bool response = false;

            try
            {
                conn.open();
                SqlCommand cmd = new SqlCommand("addHomeDeliveriesSaucers", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (var item in idSaucers)
                {
                    SqlParameter p_idHomeDel = new SqlParameter();
                    p_idHomeDel.ParameterName = "@fkIdHomeDel";
                    p_idHomeDel.SqlDbType = SqlDbType.Int;
                    p_idHomeDel.Value = idHomeDelivery;

                    SqlParameter p_idSaucer = new SqlParameter();
                    p_idSaucer.ParameterName = "@fkIDSaucer";
                    p_idSaucer.SqlDbType = SqlDbType.Int;
                    p_idSaucer.Value = item;

                    cmd.Parameters.Add(p_idHomeDel);
                    cmd.Parameters.Add(p_idSaucer);

                    cmd.ExecuteNonQuery();
                    conn.close();
                }

                response = true;


                /*int idHomeDelivery = getLastIDHomeDelivery();
                insertHomeDelivery_Saucers(idHomeDelivery, idSaucers);*/
            }
            catch (Exception e)
            {
                throw;
            }

            return response;
        }
    }
}
