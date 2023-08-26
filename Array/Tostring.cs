using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Tostring
    {
        public class Product
        {
            private int id;
            private string name;
            private int price;
            public Product(int id,string name,int price)
            {
                this.id = id;
                this.name = name;
                this.price = price;
            }
            public override string ToString()
            {
                return $"Id={id},Name={name},Price={price}";
            }
        }
        public class Program
        {
            static void Main(string[] args)
            {
                Product p1 = new Product(1, "Pen", 100);
                //Console.WriteLine(p1);
                // OR
                Console.WriteLine(p1.ToString());
            }
        }
    }
}
