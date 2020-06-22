using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            Name = name;
            grades =new List<double>();
        }
        private List<double> grades;
        public string Name;
        

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid Grade !!!");
            }
              
        }


        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double .MaxValue;
            
            // foreach(var grade in grades)
            // {
            //     result.High = Math.Max(grade, result.High);
            //     result.Low = Math.Min(grade, result.Low);
            //     result.Average += grade;
            // }

            //var index = 0;

            // do
            // {
            //     result.High = Math.Max(grades[index], result.High);
            //     result.Low = Math.Min(grades[index], result.Low);
            //     result.Average += grades[index];
            //     index ++;
            // }
            // while ( index < grades.Count );

            for (var index = 0; index < grades.Count; index += 1)
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
            }
            result.Average /= grades.Count;

            switch(result.Average)
            {
                case var d when d >= 90.0:
                            result.Letter = 'A';
                            break;
                case var d when d >= 80.0:
                            result.Letter = 'B';
                            break;  
                case var d when d >= 70.0:
                            result.Letter = 'C';
                            break;  
                case var d when d >= 60.0:
                            result.Letter = 'D';
                            break; 
                case var d when d >= 50.0:
                            result.Letter = 'E';
                            break;  
                default:
                            result.Letter = 'F';
                            break;    
            }

            return result;
            
        }
    }
}