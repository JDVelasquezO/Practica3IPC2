using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Employee_Logic
    {
        Employee_Data employee_Data = new Employee_Data();

        public bool InsertEmployee(Employee employee)
        {
            return employee_Data.InsertEmployee(employee);
        }

        public List<String> getReceptorEmployee()
        {
            return employee_Data.getReceptorEmployee();
        }

        public List<String> getDeliveryEmployee()
        {
            return employee_Data.getDeliveryEmployee();
        }
    }
}
