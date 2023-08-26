using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{ 
    public enum Departments { HR=100,Admin=200,Sales=300,Marketing=400,Dev=500,Testing=600}
    public class Employee1
    {
        private int id, salary;
        private string name;
        private int age;
        private Departments department;
        public Employee1(int id, int salary,string name,int age,Departments department)
        {
            this.id = id;
            this.salary = salary;
            this.name = name;
            this.age = age;
            this.department = department;
        }
        public override string ToString()
        {
            return $"Id={id},Name={name},Salary={salary},Age={age},Department={department}";
        }
    }
}
