using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3.Employee
{
    public partial class RegisterEmployee : Form
    {
        Type_Employee_Logic type_Employee_Logic = new Type_Employee_Logic();
        Employee_Logic employee_Logic = new Employee_Logic();

        public RegisterEmployee()
        {
            InitializeComponent();
        }

        private void RegisterEmployee_Load(object sender, EventArgs e)
        {
            LoadForm.centerForm(this);
            txtID.Focus();
            cbxTypeEmployees.Text = "Escoge un tipo de Empleado";
            LoadForm.fillCbx(cbxTypeEmployees, type_Employee_Logic.getListTypesEmployee());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entity.Employee employee = new Entity.Employee();

            employee.id_employee = Convert.ToInt32(txtID.Text);
            employee.first = txtFirst.Text;
            employee.last = txtLast.Text;
            employee.phone = txtPhone.Text;
            employee.address = txtAddress.Text;
            employee.cui = Convert.ToInt32(txtCUI.Text);
            employee.salary = float.Parse(txtSalary.Text);

            int idTypeEmployee = type_Employee_Logic.getIdByTypeEmployee(cbxTypeEmployees.Text);
            employee.type_Employee.id_type_employee = idTypeEmployee;

            if (employee_Logic.InsertEmployee(employee))
            {
                MessageBox.Show("Se inserto correctamente");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
