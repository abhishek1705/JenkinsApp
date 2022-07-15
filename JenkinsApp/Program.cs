using System;
using Mathdll;

namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins");
            Console.WriteLine("On Github");
            Console.ReadLine();

            MyMaths math = new MyMaths();

            int additon = math.Add(5, 5);
            int multiplication = math.Multiply(5, 10);

            Console.WriteLine($"Addition: {additon} Multiplication:{multiplication}");


        }
    }
}
