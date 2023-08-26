// See https://aka.ms/new-console-template for more information
using Array;

namespace array
{
   public class program
    {
        static void Main(string[] args)
        {
            // Product class.
            //Product[] list = new Product[3]
            //{
            //    new Product{Id=1,Name="Pen",Price=10 },
            //    new Product{Id=2,Name="Book",Price=500},
            //    new Product{Id=3,Name="pencil",Price=10}

            //};
            //foreach (Product p in list)
            //{
            //    Console.WriteLine($"{p.Id},{p.Name},{p.Price}");
            //}

            //Employee[] list1 = new Employee[2]
            //{
            //    new Employee{Id=1,Name="Vaishu",Payment=25000},
            //    new Employee{Id=2,Name="Ashwini",Payment=30000}
            //};
            //foreach (Employee emp in list1)
            //{
            //    Console.WriteLine($"{emp.Id},{emp.Name},{emp.Payment}");
            //}


            //Book[] list2 = new Book[1]
            //{
            //    new Book{Id=101,Name="Sucess",Auther="R.j.mishra",Price=800}
            //};
            //foreach (Book book in list2)
            //{
            //    Console.WriteLine($"{book.Id},{book.Name},{book.Auther},{book.Price}");
            //}



            // Product1 using enum.
            //Product1 p1 = new Product1(1, "Notebook",100, Categories.HomeNeeds);
            //Console.WriteLine(p1);
            //Product1 p2 = new Product1(2, "Pensil",10, Categories.Cloths);
            //Console.WriteLine(p2);
            //Product1 p3 = new Product1(3, "Pen",25, Categories.Furniture);
            //Console.WriteLine(p3);



            // Employee1 using enum.
            //Employee1 e1 = new Employee1(1, 40000, "Tushar", 25,Departments.Sales);
            //Console.WriteLine(e1);
            //Employee1 e2 = new Employee1(2, 50000, "Sita", 30, Departments.HR);
            //Console.WriteLine(e2);



            // Employee2
            Employee2[] emp = new Employee2[3];
            emp[0] = new Employee2(1, "Tushar", 25000);
            emp[1] = new Employee2(2, "Ram", 30000);
            emp[2] = new Employee2(3, "Mona", 14000);
            foreach (Employee2 e in emp)
            {
                Console.WriteLine(e);
            }
            for(int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine(emp[i]);

            }
        }
    } 


    
}
