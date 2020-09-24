using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        public Teacher Teacher { get; set; }
        public string Name { get; set; }
        public List<Student> Roster { get; set; }

        public Course (Teacher teacher, string name, List<Student> roster)
        {
            Teacher = teacher;
            Name = name;
            Roster = roster;
        }

        public Course (Teacher teacher, string name)
        {
            Teacher = teacher;
            Name = name;
            Roster = new List<Student> { };
        }
    }
}
