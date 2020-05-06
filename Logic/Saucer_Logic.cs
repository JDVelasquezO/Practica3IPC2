using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Saucer_Logic
    {
        Saucer_Data saucer_Data = new Saucer_Data();

        public List<Saucer> getSaucers()
        {
            return saucer_Data.getSaucers();
        }
    }
}
