using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var x = new SimpleMathComponent.SimpleMath();
            Console.WriteLine(x.add(5.5, 6.5).ToString());
        }
    }
}
