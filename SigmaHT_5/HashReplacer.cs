using System;
using System.Linq;
using System.IO;

namespace SigmaHT_5
{
    class HashReplacer
    {
        private string[] Text;

        public HashReplacer(string filePath)
        {
            GetTextFromFile(filePath);

            int hashCounter = 0,index;
            int hashCount = CountHashs() / 2;

            for (index = 0; index < Text.Length; index++)
            {
                hashCounter += Text[index].Count(n => n == '#');
                Text[index] = Text[index].Replace("#", "<");
                if (hashCounter == hashCount)
                    break;
            }

            hashCounter = 0;

            for (int i = index; i < Text.Length; i++)
            {
                hashCounter += Text[i].Count(n => n == '#');
                Text[i] = Text[i].Replace("#", ">");
                if (hashCounter == hashCount)
                    break;
            }

        }

        public int CountHashs()
        {
            int count = 0;

            for (int i = 0; i < Text.Length; i++)
            {
                count += Text[i].Count(n => n == '#');
            }

            return count;
        }

        public void GetTextFromFile(string filePath)
        {
            StreamReader streamReader = new StreamReader(filePath);

            string text = streamReader.ReadToEnd().Replace("\r", String.Empty);

            Text = text.Split('\n');
        }

        public override string ToString()
        {
            string output = String.Empty;

            for (int i = 0; i < Text.Length; i++)
            {
                output += Text[i] + "\n";
            }

            return output;
        }
    }
}
