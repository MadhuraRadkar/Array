using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{   
      // Using enum.
    public enum Categories { Furniture = 1, Electronics, Cloths, HomeNeeds }

    public class Product1
    {
        private int id , price;
        private string name;
        private Categories category;
        public Product1(int id,string name,int price,Categories category) // To display product details.
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.category = category;
        }
        // using ToString() method.
        public override string ToString()
        {
            return $"Id={id},Name={name},Price={price},category = {category}";
        }

    }
}
