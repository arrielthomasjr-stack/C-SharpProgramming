using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_Thomas
{
    public class Student
    {
        private double gpa;
        public static int TotalStudents = 0;
        public double Gpa
        {
            get { return gpa; }
            set
            {
                if (value >= 0.0 && value <= 4.0)
                    gpa = value;
            }
        }

        public string Name { get; set; }

        public Student(string name, double gpa)
        {
            Name = name;
            Gpa = gpa;
            TotalStudents++;
        }

        public Student(string name) : this(name, 0.0)
        {
            // TotalStudents is already incremented by the constructor above
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} - GPA: {Gpa:F2}");
        }


    }


}
