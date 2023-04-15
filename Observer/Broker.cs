using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Broker : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Брокер обновился");
        }
    }
}
