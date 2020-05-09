using DataAccess;
using System;
using Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Client_Logic
    {
        Client_Data client_Data = new Client_Data();

        public List<Client> getClient()
        {
            return client_Data.getClient();
        }

        public Client searchClientByCUI(int cui)
        {
            return client_Data.searchClientByCUI(cui);
        }
    }
}
