using System;

namespace SigmaHT_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashReplacer hashReplacer = new HashReplacer(@"C:\Users\User\source\repos\SigmaHT_5\SigmaHT_5\Input.txt");

            Console.WriteLine(hashReplacer);
        }
    }
}
