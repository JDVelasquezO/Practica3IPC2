﻿using Practica3.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadForm.centerForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterEmployee registerEmployee = new RegisterEmployee();
            registerEmployee.Show();
        }
    }
}
