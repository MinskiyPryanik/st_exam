using System;

namespace GenericSample
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Client<string> client = new Client<string>("123ABC", "Игорь");
            Client<int> client1 = new Client<int>(123678, "Иван");
            Client<char> client2 = new Client<char>('1', "Глеб");

            string clientCodestr = client.ClientCode;
            int clientCodeint = client1.ClientCode;
            char clientCodechar = client2.ClientCode;

            Console.WriteLine($"{client.Name}, {clientCodestr}");
            Console.WriteLine($"{client1.Name}, {clientCodeint}");
            Console.WriteLine($"{client2.Name}, {clientCodechar}");

            Console.ReadKey();
        }

    }
}
