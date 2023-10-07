namespace ObserverExample
{
    internal partial class Program
    {
        public interface IObject
        {
            void Add(IObserver observer);
            void Remove(IObserver observer);
            void Notify();
        }

    }
}
