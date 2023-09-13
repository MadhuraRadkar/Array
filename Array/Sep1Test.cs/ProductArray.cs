using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Sep1Test.cs
{  //Mock Q5. Create a product class and display product using array.
    public class ProductArray
    {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Id { get; set; }
       
        public ProductArray(string name, double price , int id)
        {
            Name = name; 
            Price = price;
            Id = id;
        }
    }
    public class ProgramProduct
    {
        static void Main(string[] args)
        {
            ProductArray[] prod = new ProductArray[3];
            prod[0] = new ProductArray("Pen", 50, 1);
            prod[1] = new ProductArray("Notebook", 100, 2);
            prod[2] = new ProductArray("Pencil", 10, 3);

            foreach (ProductArray item in prod)
            {
                Console.WriteLine("Name "+item.Name);
                Console.WriteLine("ID "+item.Id);
                Console.WriteLine("Price "+item.Price);
            }
            
        }
    }
}