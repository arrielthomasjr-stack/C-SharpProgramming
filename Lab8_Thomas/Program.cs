using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_Thomas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ada Lovelace", 3.9);
            Student s2 = new Student("Alan Turing", 4.0);
            Student s3 = new Student("Grace Hopper"); // uses the overload, gpa defaults to 0.0

            s1.DisplayInfo();
            s2.DisplayInfo();
            s3.DisplayInfo();

            Console.WriteLine($"Total students created: {Student.TotalStudents}");

        }
    }
}
