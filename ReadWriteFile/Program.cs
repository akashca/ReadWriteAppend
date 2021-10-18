using System;
using System.IO;

namespace ReadWriteFile
{
    class Program
    {   

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Press 1 for Write the File:");
                Console.WriteLine("Press 2 for Show the File:");
                Console.WriteLine("Press 3 for Exit from the File:");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    writeInput();
                }

                else if (input == "2")
                {
                    showInput();
                }

                else if (input == "3")
                {
                    Console.WriteLine("Exist");
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input");
                }

                static void writeInput()
                {
                    string path = @"C:\Users\Cloud Analogy\Desktop\RW\write.txt";

                    using (StreamWriter writetext = File.AppendText(path))
                    {
                        writetext.WriteLine(Console.ReadLine());
                    }

                }

                static void showInput()
                {
                    string path = @"C:\Users\Cloud Analogy\Desktop\RW\write.txt";

                    using (StreamReader readtext = new StreamReader(path))
                    {
                        string readText = File.ReadAllText(path);
                        Console.WriteLine(readText);
                    }
                }
            }
            
        }

    }
    
}
