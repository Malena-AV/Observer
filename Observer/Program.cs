using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Broker broker = new Broker();

            Stock stock = new Stock(new StockInfo(), new List<IObserver>());
            stock.RegisterObserver(bank);
            stock.RegisterObserver(broker);
            stock.Market();

            stock.RemoveObserver(broker);
            stock.Market();

            Console.ReadLine();
        }
    }
}
