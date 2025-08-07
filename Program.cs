using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_5Student_Grade_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            Dictionary<char, int> gradeCounts = new Dictionary<char, int>()
        {
            {'A', 0},
            {'B', 0},
            {'C', 0},
            {'D', 0},
            {'F', 0}
        };

            Console.WriteLine("Enter 7 student grades (0-100):");
            for (int i = 0; i < 7; i++)
            {
                while (true)
                {
                    Console.Write($"Grade {i + 1}: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int grade) && grade >= 0 && grade <= 100)
                    {
                        grades.Add(grade);
                        break;
                    }
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                }
            }

            Console.WriteLine("\nGrade Report:");
            Console.WriteLine("-------------");
            foreach (int grade in grades)
            {
                char letterGrade = GetLetterGrade(grade);
                gradeCounts[letterGrade]++;
                Console.WriteLine($"Score: {grade} - Grade: {letterGrade}");
            }
            Console.WriteLine("\nGrade Distribution:");
            foreach (var kvp in gradeCounts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} student(s)");
            }
        }

        static char GetLetterGrade(int score)
        {
            switch (score)
            {
                case int n when n >= 90 && n <= 100:
                    return 'A';
                case int n when n >= 80 && n < 90:
                    return 'B';
                case int n when n >= 70 && n < 80:
                    return 'C';
                case int n when n >= 60 && n < 70:
                    return 'D';
                default:
                    return 'F';
            }
        }
    }
}
    

