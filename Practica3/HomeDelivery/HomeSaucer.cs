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
    }
}
