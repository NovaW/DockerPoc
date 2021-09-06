using System;
using System.Threading;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello World!");
                Thread.Sleep(3000);
            }
        }
    }
}
