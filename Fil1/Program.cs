using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLi1;

namespace Fil1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject() { State = 0 };

            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();

            subject.RegisterObserver(observer1);
            subject.State = 3;

            Console.WriteLine("Наблюдатель №1: " + observer1.Counter);
            Console.WriteLine("Наблюдатель №2: " + observer2.Counter + "\n");

            subject.RegisterObserver(observer2);
            subject.State = 5;

            Console.WriteLine("Наблюдатель №1: " + observer1.Counter);
            Console.WriteLine("Наблюдатель №2: " + observer2.Counter + "\n");

            subject.RemoveObserver(observer2);
            subject.State = 0;

            Console.WriteLine("Наблюдатель №1: " + observer1.Counter);
            Console.WriteLine("Наблюдатель №2: " + observer2.Counter);

            Console.ReadKey();
        }
    }
}
