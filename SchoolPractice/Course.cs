using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }


        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.
        public override string ToString()
        {
            return Topic + " (" + Instructor.LastName + ", " + enrolledStudents.Count + ")";
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.

        public override bool Equals(object obj)
        {
            if(obj == this)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Course c = obj as Course;
            if (c.Topic == Topic && c.Instructor.FirstName == Instructor.FirstName && c.Instructor.LastName == Instructor.LastName)
            {
                return true;
            } else
            {
                return false;
            }
        }


    }
}
