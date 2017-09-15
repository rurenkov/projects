

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;


//namespace app1
//{
//    public class Prog11ram
//    {



//        public static void Main(string[] args)
//        {
//            string text = "";
//            string path = @"D:\vet\sharp\projects\potok\file1.txt";

//            if (File.Exists(path))
//            {
//                text = File.ReadAllText(path);
//            }
//            else
//            {

//                Console.WriteLine("no file");
//                return;
//            }


//            int numOfChunks = 3;
//            int sizeOfChunks = text.Length / numOfChunks;

//            int startIndex1 = 0;
//            int startIndex2 = startIndex1 + (sizeOfChunks - 1);
//            int startIndex3 = startIndex2 + (sizeOfChunks - 1);

//            // save chunks to 3 variables
//            string substring1 = text.Substring(startIndex1, sizeOfChunks);
//            //   string substring2 = text.Substring(startIndex2, sizeOfChunks);
//            // string substring3 = text.Substring(startIndex3, sizeOfChunks);

//            // additional array for results
//            char[] resultArray = new char[substring1.Length];
//            Workers.ReplaceLetters(resultArray, substring1);


//            // write to file

//            StreamWriter sw = new StreamWriter(@"D:\vet\sharp\projects\potok\fileout.txt");
//            sw.Write(resultArray);
//            sw.Close();


//            //    File.WriteAllLines(@"D:\vet\sharp\projects\potok\fileout.txt",s);


//            // print initial data
//            Console.WriteLine("lenght of file" + " " + text.Length);
//            Console.WriteLine("size of chunks" + " " + sizeOfChunks);
//            Console.WriteLine("start index 1" + " " + startIndex1);
//            Console.WriteLine("start index 2" + " " + startIndex2);
//            Console.WriteLine("start index 3" + " " + startIndex3);






//            System.Console.ReadKey();
//        }
//    }





//}

















