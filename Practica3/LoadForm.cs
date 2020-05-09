using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public static class LoadForm
    {
        public static Client client = new Client();

        public static void centerForm(Form form)
        {
            form.Top = (Screen.PrimaryScreen.WorkingArea.Height - form.Height) / 2;
            form.Left = (Screen.PrimaryScreen.WorkingArea.Width - form.Width) / 2;
        }

        public static void fillCbx(ComboBox cbx, List<String> listObjects)
        {
            List<String> list = listObjects;

            foreach (var item in listObjects)
            {
                cbx.Items.Add(item);
            }
        }
    }
}
