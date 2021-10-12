using System;

namespace SigmaHT_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            PathWorker pathWorker = new PathWorker();

            Console.WriteLine(pathWorker.GetFileNameWithoutExtension());

            Console.WriteLine(pathWorker.GetRootFolder());
        }
    }
}
