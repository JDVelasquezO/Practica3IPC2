﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3.HomeDelivery
{
    public partial class HomeDelivery : Form
    {
        public HomeDelivery()
        {
            InitializeComponent();
        }

        private void HomeDelivery_Load(object sender, EventArgs e)
        {
            LoadForm.centerForm(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeSaucer saucer = new HomeSaucer();
            saucer.Show();
        }
    }
}