using System;

namespace SigmaHT_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of cube");

            int size = int.Parse(Console.ReadLine());

            Cube cube;

            try
            {
                cube = new Cube(size);

                Console.WriteLine("Enter plane:(XOY,XOZ,YOZ)");
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
