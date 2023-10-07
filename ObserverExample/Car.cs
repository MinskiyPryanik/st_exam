using System;

namespace ObserverExample
{
    internal partial class Program
    {
        public class Car : IObserver
        {
            public void Message(IObject obj)
            {
                Console.WriteLine("Toyota Mark 2");
            }
        }


    }
}
