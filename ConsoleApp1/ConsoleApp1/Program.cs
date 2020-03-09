using System;
using System.Collections.Generic;
using System.IO;

namespace CompareFiles
{
    public class Compare
    {
        static void Main(string[] args)
        {
        
                //Read file1
                StreamReader reader;
                reader = new System.IO.StreamReader("a.txt");
                string Data1 = reader.ReadToEnd();
                reader.Close();

                //Read file2

                reader = new System.IO.StreamReader("b.txt");
                string Data2 = reader.ReadToEnd();
                reader.Close();
                if (Data1 == Data2)
                {
                    Console.WriteLine("Files are not different");
                }
                else
                {
                    Console.WriteLine("Files are different");
                }
            }
        }
    } 