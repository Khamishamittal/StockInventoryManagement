using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockInventoryManagement
{

    public class Stocks
    {
        public string StockName;
        public int shares;
        public int Price;
    }
    public class StockDetails
    {
        public List<Stocks> stocks;
    }
}
