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

namespace Practica3.Bill
{
    public partial class HomeBill : Form
    {
        Bill_Logic bill_Logic = new Bill_Logic();

        public HomeBill()
        {
            InitializeComponent();
        }

        private void HomeBill_Load(object sender, EventArgs e)
        {
            LoadForm.centerForm(this);
            string fullName = $"{LoadForm.client.first_client} {LoadForm.client.last_client}";

            txtAdress.Text = LoadForm.client.address;
            txtNIT.Text = LoadForm.client.nit_client.ToString();
            txtName.Text = fullName;
            lblIDUser.Text = LoadForm.client.idDBClient.ToString();

            float totalPrice = 0;

            if (HomeDelivery.ListSaucers.saucers.Count > 0)
            {
                foreach (var item in HomeDelivery.ListSaucers.saucers)
                {
                    string saucer = $"Q.{item.costSaucer} - {item.nameSaucer}\n";
                    listSaucer.Items.Add(saucer);
                    totalPrice += item.costSaucer;
                }
            }

            lblPrice.Text = $"{totalPrice.ToString()}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entity.Bill bill = new Entity.Bill();
            bill.id_bill = Convert.ToInt32(txtNoBill.Text);
            bill.totalPrice = float.Parse(lblPrice.Text);
            bill.client.idDBClient = Convert.ToInt32(lblIDUser.Text);

            bill_Logic.InsertHomeDelivery(bill);
            MessageBox.Show("Factura Registrada");
        }
    }
}
