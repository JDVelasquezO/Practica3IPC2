using Entity;
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

namespace Practica3.HomeDelivery
{
    public partial class HomeSaucer : Form
    {
        Saucer_Logic saucer_Logic = new Saucer_Logic();

        public HomeSaucer()
        {
            InitializeComponent();
        }

        private void Saucer_Load(object sender, EventArgs e)
        {
            LoadForm.centerForm(this);
            fillTable();
        }

        public void fillTable()
        {
            dgvSaucer.Rows.Clear();

            List<Saucer> saucers = saucer_Logic.getSaucers();

            foreach (var item in saucers)
            {
                dgvSaucer.Rows.Add(item.idSaucer, item.nameSaucer, item.costSaucer, 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeDelivery homeDelivery = new HomeDelivery();
            homeDelivery.Show();
        }

        private void dgvSaucer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Saucer saucer = new Saucer();
            saucer.idSaucer = Convert.ToInt32(dgvSaucer.Rows[e.RowIndex].Cells["idSaucer"].FormattedValue.ToString());
            saucer.nameSaucer = dgvSaucer.Rows[e.RowIndex].Cells["nameSaucer"].FormattedValue.ToString();
            string quantity = dgvSaucer.Rows[e.RowIndex].Cells["quantity"].FormattedValue.ToString();
            saucer.costSaucer = float.Parse(dgvSaucer.Rows[e.RowIndex].Cells["costSaucer"].FormattedValue.ToString()) * float.Parse(quantity);

            MessageBox.Show($"Platillo {saucer.nameSaucer} agregado a la lista");
            ListSaucers.saucers.Add(saucer);
        }
    }
}