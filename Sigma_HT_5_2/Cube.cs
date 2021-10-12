using System;

namespace SigmaHT_5_2
{
    class Cube
    {
        private int[,,] cube;

        private int size;

        public Cube(int size = 0)
        {
            if (size <= 0)
                throw new ArgumentException("Size must be > 0");

            this.size = size;

            cube = new int[size, size, size];

            Random Random = new Random();

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        cube[i, j, k] = Random.Next(0, 2);
                    }
                }
            }
        }

        public string GetShadow(string plane)
        {
            if (plane != "XOY" && plane != "XOZ" && plane != "YOZ")
                throw new ArgumentException("Invalid plane");
            string output = String.Empty;
            int[,] shadow = new int[size, size];

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        switch (plane)
                        {
                            case "XOY":
                                shadow[i, j] += cube[k, i, j];
                                break;

                            case "XOZ":
                                shadow[i, j] += cube[i, j, k];
                                break;

                            case "YOZ":
                                shadow[i, j] += cube[i, k, j];
                                break;
                        }

                        if (shadow[i, j] == 1)
                            break;
                    }
                }
            }

            for (int i = 0; i < shadow.GetLength(0); i++)
            {
                for (int j = 0; j < shadow.GetLength(1); j++)
                {
                    output += shadow[i, j];
                }
                output += "\n";
            }

            return output;
        }
    }
}
