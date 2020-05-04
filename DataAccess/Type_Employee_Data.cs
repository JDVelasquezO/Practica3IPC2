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
    public class Type_Employee_Data
    {
        Connection conn = new Connection();

        public List<String> getListTypesEmployee()
        {
            List<String> list = new List<String>();

            try
            {
                conn.open();
                String nameObject = "";

                SqlCommand cmd;
                SqlDataReader reader;

                cmd = new SqlCommand($"SELECT type_employee FROM type_employee", conn.returnConn());
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nameObject = reader["type_employee"].ToString();
                    list.Add(nameObject);
                }

                conn.close();
            }
            catch (Exception)
            {
                throw;
            }

            return list;
        }

        public int getIdByTypeEmployee(string typeEmployee)
        {
            int id = 0;

            try
            {
                conn.open();
                
                SqlCommand cmd = new SqlCommand("getIdTypeEmployee", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p_typeEmployee = new SqlParameter();
                p_typeEmployee.ParameterName = "@typeEmployee";
                p_typeEmployee.SqlDbType = SqlDbType.VarChar;
                p_typeEmployee.Value = typeEmployee;

                cmd.Parameters.Add(p_typeEmployee);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["id_type_employee"]);
                }

                conn.close();
            }
            catch (Exception)
            {
                throw;
            }

            return id;
        }
    }
}
