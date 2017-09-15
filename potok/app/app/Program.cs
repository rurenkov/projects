using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;



namespace app1
{
    public class Program
    {

      //  static string string33;
        public static void Main(string[] args)
        {
            
           string path = @"D:\temp\projects\projects\potok\file1.txt";
           string text="";
           int numOfChunks = 3;
            char[] resultArray = new char[numOfChunks];
            string [] Chunks = new string[numOfChunks];

            Workers w = new Workers();

            // get results from file to string
            text=w.FileExists(path);

           // get string Array with loaded chunks
            Chunks=w.SplitToText(numOfChunks, text);
            StreamWriter sw = new StreamWriter(@"D:\temp\projects\projects\potok\fileout.txt");
            // additional array for results

            //Thread myThread = new Thread(new ParameterizedThreadStart(w.ReplaceLetters));


            for (int i = 0; i < numOfChunks; i++)
            {

                 resultArray=w.ReplaceLetters(Chunks[i]);
          //      Thread myThread = new Thread(new ParameterizedThreadStart(w.ReplaceLetters));

            //    () =>
              //  {



                //}
                //threads

             //   int number = 4;
                // создаем новый поток
            
               // myThread.Start(number);




                // write to file    



                sw.Write(resultArray);
                
            }
            sw.Close();
            



            System.Console.ReadKey();
        }
    }
}