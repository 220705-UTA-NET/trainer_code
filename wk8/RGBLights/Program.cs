using System;

namespace RGBLights
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

                for (int i = 0; i < lines.Length; i+=3)
                {
                    try
                    {
                        string lights = lines[i];
                        int time = Convert.ToInt32(lines[i+1]);
                        string expected = lines[i+2];

                        Console.WriteLine("Initial Settings: " + lights);
                        Console.WriteLine("Number Of Cycles: " + time);
                        //Console.WriteLine(expected);

                        Console.WriteLine((test.RGBLight(lights, time) == expected) ? "Pass" : "Fail");
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(lines[i] + " " + lines[i+1]);
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }
}
