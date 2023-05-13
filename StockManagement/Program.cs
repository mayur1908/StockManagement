namespace StockManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "D:\\bridgelabz\\StockManagement\\StockManagement\\jsconfig1.json";
            ReadTheData readTheData = new ReadTheData();
            StocksDetail data = readTheData.Read(path);
            Console.WriteLine("================== Names Of Stocks UC1  =================");
            for (int i = 0; i < data.typesOfStocks.Count; i++)
            {
                Console.WriteLine(data.typesOfStocks[i].name);
                Console.WriteLine(data.typesOfStocks[i].nofshare);
                Console.WriteLine(data.typesOfStocks[i].price);
                Console.WriteLine("=========================");
               Console.WriteLine("============UC2=============");
                int invetoryprice = data.typesOfStocks[i].nofshare * data.typesOfStocks[i].price;
                Console.WriteLine("The stock {0} has price of {1:C} and a quantity of {2} And the Total Amount is  {3}.", data.typesOfStocks[i].name, data.typesOfStocks[i].price, data.typesOfStocks[i].nofshare, invetoryprice);

            }
        }
    }
}