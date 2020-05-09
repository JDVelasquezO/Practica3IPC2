using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class HomeDelivery_Logic
    {
        HomeDelivery_Data homeDelivery = new HomeDelivery_Data();

        public bool InsertHomeDelivery(int id)
        {
            return homeDelivery.InsertHomeDelivery(id);
        }
    }
}
