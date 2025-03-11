using System.Diagnostics.Contracts;

namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        Professor P1 = new Professor ();
        P1.profName = "Alice";
        P1.classTeach = "Java";
        P1.SetSalary(9000);

        Professor P2 = new Professor ();
        P2.profName = "Bob";
        P2.classTeach = "Math";
        P2.SetSalary(8000);

        Student S1 = new Student ();
        S1.studentName = "Lisa";
        S1.classEnroll = "Math";
        S1.SetStudentGrade(90);

        Student S2 = new Student ();
        S2.studentName = "Tom";
        S2.classEnroll = "Math";
        S2.SetStudentGrade(80);


        Console.WriteLine("Professor " + P1.profName + " teaches " + P1.classTeach + ", and the salary is: " + P1.GetSalary());
        Console.WriteLine("Professor " + P2.profName + " teaches " + P2.classTeach + ", and the salary is: " + P2.GetSalary());

        Console.WriteLine("Student " + S1.studentName + " enrolls " + S1.classEnroll + ", and the grade is: " + S1.GetStudentGrade());
        Console.WriteLine("Student " + S2.studentName + " enrolls " + S2.classEnroll + ", and the grade is: " + S2.GetStudentGrade());

        Console.WriteLine("The salary difference between " + P1.profName + " and " + P2.profName + " is: " + (P1.GetSalary() - P2.GetSalary()));
        Console.WriteLine("The total grade of " + S1.studentName + " and " + S2.studentName + " is: " + (S1.GetStudentGrade() + S2.GetStudentGrade()));
    }

    class Professor
    {
        public string profName;
        public string classTeach; 
        private double salary; 

        public void SetSalary(double salary_amount)
        {
            salary = salary_amount;
        }

        public double GetSalary()
        {
            return salary;
        }
    }

    class Student
    {
        public string studentName;
        public string classEnroll; 
        private double studentGrade;

        public void SetStudentGrade(double newGrade)
        {
            studentGrade = newGrade;
        }

        public double GetStudentGrade()
        {
            return studentGrade;
        }
    }
}