using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAggregate<Car> carCollection = new MyAggregate<Car>();
            carCollection.Add(new Car {Model = "Lancer"});
            carCollection.Add(new Car {Model = "Impreza"});
            carCollection.Add(new Car {Model = "Lada Sedan Baklazhan"});
            carCollection.Add(new Car {Model = "Elyse"});
            carCollection.Add(new Car {Model = "Prado"});

            IIterate<Car> i = carCollection.CreateIterator();

            while (!i.IsDone())
            {
                Console.WriteLine(i.CurrentItem());
                i.MoveNext();
            }

            Console.WriteLine(carCollection[2]);

            Console.ReadKey();
        }
    }
}
