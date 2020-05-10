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
    public class Bill_Data
    {
        Connection conn = new Connection();

        public bool InsertHomeDelivery(Bill bill)
        {
            bool response = false;
            HomeDelivery_Data homeDelivery_Data = new HomeDelivery_Data();

            try
            {
                conn.open();
                SqlCommand cmd = new SqlCommand("insertBills", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p_idBill = new SqlParameter();
                p_idBill.ParameterName = "@idBill";
                p_idBill.SqlDbType = SqlDbType.Int;
                p_idBill.Value = bill.id_bill;

                SqlParameter p_idClient = new SqlParameter();
                p_idClient.ParameterName = "@idClient";
                p_idClient.SqlDbType = SqlDbType.Int;
                p_idClient.Value = bill.client.idDBClient;

                int idHomeDelivery = homeDelivery_Data.getLastIDHomeDelivery();
                SqlParameter p_idHomeDel = new SqlParameter();
                p_idHomeDel.ParameterName = "@idHomeDel";
                p_idHomeDel.SqlDbType = SqlDbType.Int;
                p_idHomeDel.Value = idHomeDelivery;

                SqlParameter p_idPrice = new SqlParameter();
                p_idPrice.ParameterName = "@price";
                p_idPrice.SqlDbType = SqlDbType.Int;
                p_idPrice.Value = bill.totalPrice;

                cmd.Parameters.Add(p_idClient);
                cmd.Parameters.Add(p_idBill);
                cmd.Parameters.Add(p_idHomeDel);
                cmd.Parameters.Add(p_idPrice);

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
