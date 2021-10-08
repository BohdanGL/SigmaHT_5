using System;

namespace SigmaHT_5
{
    class Program
    {
        static void Main(string[] args)
        {
            HashReplacer hashReplacer = new HashReplacer(@"C:\Users\User\source\repos\SigmaHT_5\SigmaHT_5\Input.txt");

            Console.WriteLine(hashReplacer);
            
            PathWorker pathWorker = new PathWorker(@"C: \Users\User\source\repos\SigmaHT_5\SigmaHT_5.sln");

            Console.WriteLine(pathWorker.GetFileNameWithoutExtension());

            Console.WriteLine(pathWorker.GetRootFolder());


            Console.WriteLine("\n\nEnter size of cube");

            int size = int.Parse(Console.ReadLine());

            Cube cube;

            try
            {
                cube = new Cube(size);

                Console.WriteLine("Enter plane:");
                Console.WriteLine("Shadow:\n" + cube.GetShadow(Console.ReadLine()));
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                return;
            }
        }
    }
}
