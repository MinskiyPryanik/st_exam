using System;

namespace ObserverExample
{
    internal partial class Program
    {
        public class Bike : IObserver
        {
            public void Message(IObject obj)
            {
                Console.WriteLine("Велосипед");
            }
        }

    }
}
