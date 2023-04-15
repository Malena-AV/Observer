using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // паттерн используется для того, чтобы была возможность использовать какой-то метод у объектов,
    // наблюдающих за изменениями другого объекта
    class Stock : IObservable
    {
        List<IObserver> observers;
        StockInfo info;

        public Stock(StockInfo info, List<IObserver> observers)
        {
            this.observers = observers;
            this.info = info;
        }
        public void NotifyObservers()
        {
            foreach (var observer in this.observers)
            {
                observer.Update();
            }
        }

        public void RegisterObserver(IObserver o)
        {
            this.observers.Add(o); 
        }

        public void RemoveObserver(IObserver o)
        {
            this.observers.Remove(o);
        }

        public void Market()
        {
            Random random = new Random();
            this.info.Euro = random.Next(80, 90);
            this.info.USD = random.Next(90, 100);
            this.NotifyObservers();
        }
    }
}
