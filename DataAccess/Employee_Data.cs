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
    public class Employee_Data
    {
        Connection conn = new Connection();

        public bool InsertEmployee(Employee employee)
        {
            bool response = false;

            try
            {
                conn.open();
                SqlCommand cmd = new SqlCommand("add_employee", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p_idEmployee = new SqlParameter();
                p_idEmployee.ParameterName = "@idEmployee";
                p_idEmployee.SqlDbType = SqlDbType.Int;
                p_idEmployee.Value = employee.id_employee;

                SqlParameter p_first = new SqlParameter();
                p_first.ParameterName = "@first";
                p_first.SqlDbType = SqlDbType.VarChar;
                p_first.Value = employee.first;

                SqlParameter p_last = new SqlParameter();
                p_last.ParameterName = "@last";
                p_last.SqlDbType = SqlDbType.VarChar;
                p_last.Value = employee.last;

                SqlParameter p_phone = new SqlParameter();
                p_phone.ParameterName = "@phone";
                p_phone.SqlDbType = SqlDbType.VarChar;
                p_phone.Value = employee.phone;

                SqlParameter p_address = new SqlParameter();
                p_address.ParameterName = "@address";
                p_address.SqlDbType = SqlDbType.VarChar;
                p_address.Value = employee.address;

                SqlParameter p_cui = new SqlParameter();
                p_cui.ParameterName = "@cui";
                p_cui.SqlDbType = SqlDbType.Int;
                p_cui.Value = employee.cui;

                SqlParameter p_salary = new SqlParameter();
                p_salary.ParameterName = "@salary";
                p_salary.SqlDbType = SqlDbType.Float;
                p_salary.Value = employee.salary;

                SqlParameter p_idTypeEmployee = new SqlParameter();
                p_idTypeEmployee.ParameterName = "@fkIdTypeEmployee";
                p_idTypeEmployee.SqlDbType = SqlDbType.Int;
                p_idTypeEmployee.Value = employee.type_Employee.id_type_employee;

                cmd.Parameters.Add(p_idEmployee);
                cmd.Parameters.Add(p_first);
                cmd.Parameters.Add(p_last);
                cmd.Parameters.Add(p_phone);
                cmd.Parameters.Add(p_address);
                cmd.Parameters.Add(p_cui);
                cmd.Parameters.Add(p_salary);
                cmd.Parameters.Add(p_idTypeEmployee);

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
