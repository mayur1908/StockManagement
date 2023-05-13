using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    public class StocksDetail
    {
        public List<TypesOfStocks> typesOfStocks;
    }
    public class TypesOfStocks
    {
        public string name; 
        public int nofshare;
        public int price;
    }
}
