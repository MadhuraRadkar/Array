using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Sep1Test.cs
{  //Mock.Q9.Create a Student class and display students.
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }

        public Student(int id, string name, double percentage)
        {
            Id = id;
            Name = name;
            Percentage = percentage;
        }
        public void Display()
        {
            Console.WriteLine($"Student id={Id},Name={Name}, Percentage={Percentage}");
        }
    }
    public class ProgramStud
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student(10, "Prashant", 83.62);
            stud1.Display();

            Student stud2 = new Student(11, "Priya", 73.54);
            stud2.Display();

        }
    }
}
