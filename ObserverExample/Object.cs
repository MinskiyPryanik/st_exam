using System.Collections.Generic;

namespace ObserverExample
{
    internal partial class Program
    {
        public class Object : IObject
        {
            List<IObserver> Transports = new List<IObserver>();
            public void Add(IObserver observer)
            {
                Transports.Add(observer);
            }
            public void Remove(IObserver observer)
            {
                Transports.Remove(observer);
            }
            public void Notify()
            {
                foreach (var Transport in Transports)
                {
                    Transport.Message(this);
                }
            }
        }

    }
}
