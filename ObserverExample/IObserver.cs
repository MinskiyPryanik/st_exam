namespace ObserverExample
{
    internal partial class Program
    {
        public interface IObserver
        {
            void Message(IObject obj);
        }

    }
}
