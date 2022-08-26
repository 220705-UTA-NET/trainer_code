using System;

namespace Neighbors
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
                    int N = Convert.ToInt32(lines[i]);

                    string[] tmp = lines[i+1].Split();

                    int[] A = new int[N];

                    for (int j = 0; j < N; j++)
                    {
                        A[j] =  Convert.ToInt32(tmp[j]);
                    }

                    try
                    {
                        Console.WriteLine("Number Of Houses: " + N);

                        Console.Write("House Positions: ");
                        foreach (int j in A)
                        {
                            Console.Write(j + " ");
                        }
                        Console.WriteLine();

                        Console.WriteLine((test.minDist(N, A) == Convert.ToInt32(lines[i+2])) ? "Pass" : "Fail" );
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
