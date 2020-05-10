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
using Entity;

namespace Practica3.HomeDelivery
{
    public partial class HomeDelivery : Form
    {
        List<int> idSaucers = new List<int>();

        Employee_Logic employee_Logic = new Employee_Logic();
        Client_Logic client_Logic = new Client_Logic();
        HomeDelivery_Logic homeDelivery_Logic = new HomeDelivery_Logic();
        
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
                    string saucer = $"{item.idSaucer} - Q.{item.costSaucer} - {item.nameSaucer}\n";
                    listSaucer.Items.Add(saucer);
                    idSaucers.Add(item.idSaucer);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadForm.client.idDBClient = Convert.ToInt32(lblCode.Text);
            LoadForm.client.nit_client = Convert.ToInt32(txtNIT.Text);
            LoadForm.client.first_client = txtFirst.Text;
            LoadForm.client.last_client = txtLast.Text;
            LoadForm.client.address = txtAddress.Text;

            foreach (var item in ListSaucers.saucers)
            {
                LoadForm.client.saucers.Add(item);
            }

            homeDelivery_Logic.InsertHomeDelivery(Convert.ToInt32(lblCode.Text), idSaucers);

            HomeBill homeBill = new HomeBill();
            homeBill.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int cui = Convert.ToInt32(cbxClients.SelectedItem.ToString().Split(' ')[0]);
            Client client = client_Logic.searchClientByCUI(cui);

            fillForm(client);
        }

        public void fillForm(Client client)
        {
            lblCode.Text = client.idDBClient.ToString();
            txtID.Text = client.id_client.ToString();
            txtNIT.Text = client.nit_client.ToString();
            txtFirst.Text = client.first_client;
            txtLast.Text = client.last_client;
            txtPhone.Text = client.phone;
            txtAddress.Text = client.address;
        }
    }
}
