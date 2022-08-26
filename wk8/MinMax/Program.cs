using System;

namespace MinMax
{
    class Program
    {
        public static void Main(string[] args)
        {
            Test test = new Test();
            string path = "./input.txt";
            Console.WriteLine("Starting...");
            Thread.Sleep(1000);
            Console.WriteLine("Reading from file...");

            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist.");
            }
            else
            {
                string[] lines = File.ReadAllLines(path);

                for (int i = 0; i < lines.Length; i+=2)
                {
                    try
                    {
                        Console.WriteLine("Input Sequence: " + lines[i]);
                        Console.WriteLine((test.addingNumbers(lines[i])) == Convert.ToInt32(lines[i+1]) ? "Pass" : "Fail");
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(lines[i]);
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }
}
