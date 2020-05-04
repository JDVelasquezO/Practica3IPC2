using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Type_Employee_Logic
    {
        Type_Employee_Data type_Employee_Data = new Type_Employee_Data();

        public List<String> getListTypesEmployee()
        {
            return type_Employee_Data.getListTypesEmployee();
        }

        public int getIdByTypeEmployee(string typeEmployee)
        {
            return type_Employee_Data.getIdByTypeEmployee(typeEmployee);
        }
    }
}
