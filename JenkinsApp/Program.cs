﻿using System;
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

            int a, b;
            Console.WriteLine("Enter 2 values");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            MyMaths math = new MyMaths();

            int additon = math.Add(a, b);
            int multiplication = math.Multiply(a, b);

            Console.WriteLine($"Addition: {additon} Multiplication:{multiplication}");

            Console.ReadLine();


        }
    }
}
