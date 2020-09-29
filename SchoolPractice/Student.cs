using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            double startingQualityScore = NumberOfCredits * Gpa;
            double totalQualityScore = startingQualityScore + (courseCredits * grade);
            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
            // Update the appropriate properties: NumberOfCredits, Gpa
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            if(credits >= 0 && credits < 30)
            {
                return "Freshman";
            } else if (credits >= 30 && credits < 60)
            {
                return "Sophomore";
            } else if (credits >= 60 && credits < 90)
            {
                return "Junior";
            } else if (credits >= 90)
            {
                return "Senior";
            }
            return "invalid credits";
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.
        public override string ToString()
        {
            return Name + " (" + this.GetGradeLevel(NumberOfCredits) + ", " + Gpa + ")";
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.
        public override bool Equals(object obj)
        {
            if(obj == this)
            {
                return true;
            }
            if(obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Student s = obj as Student;
            return s.StudentId == StudentId;
        }


    }
}
