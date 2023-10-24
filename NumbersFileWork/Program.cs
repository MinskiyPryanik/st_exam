using System;
using System.IO;
using System.Text;

namespace NumbersFileWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"numberFile.txt";
            string input = Console.ReadLine();
            string isDigit = "";
            foreach (char i in input)
            {
                if (int.TryParse(i.ToString(), out int err)) isDigit += i.ToString();
            }
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                byte[] buffer = Encoding.Default.GetBytes(isDigit);
                stream.Write(buffer, 0, buffer.Length);
            }

            using (FileStream read = File.OpenRead(path))
            {
                byte[] buffer = new byte [read.Length];
                read.Read(buffer, 0, buffer.Length);
                Console.WriteLine(Encoding.Default.GetString(buffer));
            }
            Console.ReadKey();

        }
    }
}
