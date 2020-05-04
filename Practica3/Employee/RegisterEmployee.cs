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

        public RegisterEmployee()
        {
            InitializeComponent();
        }

        private void RegisterEmployee_Load(object sender, EventArgs e)
        {
            txtCUI.Focus();
            LoadForm.centerForm(this);
            cbxTypeEmployees.Text = "Escoge un tipo de Empleado";
            LoadForm.fillCbx(cbxTypeEmployees, type_Employee_Logic.getListTypesEmployee());
        }
    }
}
