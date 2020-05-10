using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Bill_Logic
    {
        Bill_Data bill_Data = new Bill_Data();

        public bool InsertHomeDelivery(Bill bill)
        {
            return bill_Data.InsertHomeDelivery(bill);
        }
    }
}
