using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Bill
    {
        public int id_bill { get; set; }
        public string serie { get; set; }
        public Client client = new Client();
        public float totalPrice { get; set; }
    }
}
