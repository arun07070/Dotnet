using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodeChallenge2
{
    internal class Products
    {
        public int ProductId;
        public string ProductName;
        public double Price;
        public void GetDetails()
        {
            Console.Write("Enter Product ID: ");
            ProductId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product Name: ");
            ProductName = Console.ReadLine();
            Console.Write("Enter Price: ");
            Price = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine(ProductId + "\t" + ProductName + "\t" + Price);
        }
    }
    class Sort
    {
        static void Main(string[] args)
        {
            Products[] products = new Products[10];
            Console.WriteLine("Enter details for 10 products:\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nProduct " + (i + 1));
                products[i] = new Products();
                products[i].GetDetails();
            }
            for (int i = 0; i < 10 - 1; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (products[i].Price > products[j].Price)
                    {
                        Products temp = products[i];
                        products[i] = products[j];
                        products[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n--- Products Sorted by Price ---");
            Console.WriteLine("ID\tName\tPrice");
            foreach (Products p in products)
            {
                p.Display();
            }
        }
    }
}
