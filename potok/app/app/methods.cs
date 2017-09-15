using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace app1
{


    public class Workers
    {
        string text = "";


        public string FileExists(string path)
        {

            if (File.Exists(path))
            {
                text = File.ReadAllText(path);
                return text;
            }
            else
            {

                Console.WriteLine("no file");
                return string.Empty;
            }

        }


        public string[] SplitToText(int numOfChunks, string text)
        {

            string[] Chunks = new string[numOfChunks];
            int[] startIndexes = new int[numOfChunks];

            int sizeOfChunks = text.Length / numOfChunks;

            Console.WriteLine("size of chunks:" + sizeOfChunks);

            for (int i = 0; i < numOfChunks; i++)
            {

                if (i != 0)
                {

                    startIndexes[i] = startIndexes[i - 1] + (sizeOfChunks);
                }
                Console.WriteLine("start index of chunk:" + startIndexes[i]);

            }

            for (int i = 0; i < numOfChunks; i++)
            {
                // save chunks to 3 variables
                Chunks[i] = text.Substring(startIndexes[i], sizeOfChunks);

            }
            return Chunks;


        }


        public  char[] ReplaceLetters(string substring)
        {
            //to object
            //string substring = (string)obj

            char[] result = new char[substring.Length];
            for (int i = 0; i < substring.Length; i++)
            {
                if (char.IsLetter(substring[i]))
                {
                    if (char.IsLower(substring[i]))
                    {
                        result[i] = char.ToUpper(substring[i]);
                    }
                    else
                    {
                        result[i] = char.ToLower(substring[i]);

                    }
                }

                else
                {
                    result[i] = substring[i];

                }

            }
            return result;
        }

    

    }
}