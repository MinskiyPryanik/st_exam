using System;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();

            publisher.CustomEvent += HandleEvent;
            publisher.TriggerEvent();
            Console.ReadKey();
        }

        static void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Это событие");
        }
    }

    class EventPublisher
    {
        
        public event EventHandler CustomEvent;
        public void TriggerEvent()
        {
            if (CustomEvent != null)
            {
                CustomEvent(this, EventArgs.Empty);
            }
        }
    }
}