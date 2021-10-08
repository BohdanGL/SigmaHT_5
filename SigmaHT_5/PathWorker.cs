using System;

namespace SigmaHT_5
{
    class PathWorker
    {
        public string FilePath { get; set; }

        public PathWorker(string filePath = @"C: \Users\User\source\repos\SigmaHT_5\SigmaHT_5.sln")
        {
            FilePath = filePath;
        }

        public string GetFileNameWithoutExtension()
        {
            string[] pathParts = FilePath.Split('\\');

            return pathParts[pathParts.Length - 1].Split('.')[0];
        }

        public string GetRootFolder()
        {
            string[] pathParts = FilePath.Split('\\');

            return pathParts[0].Replace(" ", String.Empty);
        }
    }
}
