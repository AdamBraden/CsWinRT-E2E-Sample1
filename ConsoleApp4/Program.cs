using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            WinRT.ComWrappersSupport.InitializeComWrappers();
            Console.WriteLine("Hello World!");
            var x = new SimpleMathCppWinRT.SimpleMath();

        }
    }
}
