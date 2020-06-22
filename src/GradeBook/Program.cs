using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Tisha's Grade Book");

            Console.WriteLine("Enter a grade or 'q' to quit :");

            while(true)
            {
                 var input = Console.ReadLine();

                 if (input == "q")
                 {
                     break;
                 }
                 var grade = double.Parse(input);
                 book.AddGrade(grade);
            }       

            var stats = book.GetStatistics();

            Console.WriteLine($"Below are the statistics for {book.Name}");
            Console.WriteLine("#####################################");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The average of the grades is {stats.Average:N2}");
            Console.WriteLine($"The Letter grade is {stats.Letter}");
/*
            var grades = new List<double> {20.13, 12.16, 17.96, 34.67};
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(var grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
                lowGrade = Math.Min(grade, lowGrade);
                result += grade;
            }

            result /= grades.Count;
            Console.WriteLine($"The average of the grade is {result:N2}");     
            */    
        }
    }
}
