using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Client
    {
        public int idDBClient { get; set; }
        public int id_client { get; set; }
        public int nit_client { get; set; }
        public string first_client { get; set; }
        public string last_client { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public List<Saucer> saucers = new List<Saucer>();
    }
}
