﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    students.Add(newStudent);
                }
            }
            while (newStudent != "");

            // Get student grades
            foreach (string student in students)
            {
                Console.Write("Grade for " + student + ": ");
                double newGrade = double.Parse(Console.ReadLine());
                grades.Add(newGrade);
            }
            StringBuilder newStudents = new StringBuilder();

            Console.WriteLine("\nClass roster:");
            for (int i = 0; i < students.Count; i++)
            {
                newStudents.Append(students[i]).Append("(" + grades[i] + ")" + "\n");
                
                //Console.WriteLine(students[i] + " (" + grades[i] + ")");
            }
            Console.WriteLine(newStudents);

            double sum = grades.Sum();
            double avg = sum / grades.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        
        }
       
    }
}
