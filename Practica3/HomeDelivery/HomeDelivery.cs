using Practica3.Bill;
using System;
using Logic;
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
        Employee_Logic employee_Logic = new Employee_Logic();
        Client_Logic client_Logic = new Client_Logic();
        
        public HomeDelivery()
        {
            InitializeComponent();
        }

        private void HomeDelivery_Load(object sender, EventArgs e)
        {
            LoadForm.centerForm(this);
            cbxReceptionEmployee.Text = "Recepcionista";
            cbxAtendedEmployee.Text = "Repartidor";
            cbxClients.Text = "Clientes";

            List<String> nameClients = new List<string>();

            foreach (var item in client_Logic.getClient())
            {
                nameClients.Add($"{item.id_client} - {item.first_client} {item.last_client}");
            }

            LoadForm.fillCbx(cbxReceptionEmployee, employee_Logic.getReceptorEmployee());
            LoadForm.fillCbx(cbxAtendedEmployee, employee_Logic.getDeliveryEmployee());
            LoadForm.fillCbx(cbxClients, nameClients);
            fillListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeSaucer saucer = new HomeSaucer();
            saucer.Show();
        }

        public void fillListView()
        {
            // var items = new ListViewItem();
            if (ListSaucers.saucers.Count > 0)
            {
                foreach (var item in ListSaucers.saucers)
                {
                    string saucer = $"Q.{item.costSaucer} - {item.nameSaucer}\n";
                    listSaucer.Items.Add(saucer);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomeBill homeBill = new HomeBill();
            homeBill.Show();
        }
    }
}
