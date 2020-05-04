using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Employee
    {
        public int id_employee { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public int cui { get; set; }
        public float salary { get; set; }
        public Type_Employee type_Employee = new Type_Employee();
    }
}
