using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();
            Student student1 = new Student("Carol", 123, 1, 4.0);

            listOfStudents.Add(student1);

            Teacher teacher1 = new Teacher();

            Course newCourse = new Course(teacher1, "Calculus", listOfStudents);

            Console.WriteLine(student1);
            Console.WriteLine(listOfStudents[0].Name);
            Console.WriteLine(newCourse.Roster[0].Name + newCourse.Roster[0].Gpa);
        }
    }
}
