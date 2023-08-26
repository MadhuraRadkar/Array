using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Employee2
    {
        private int id;
        private string name;
        private int salary;
        public Employee2(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public string ToString()
        {
            return id + " " + name + " " + salary;
        }

    }
}
