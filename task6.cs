using System;
class Product
{
    public int id;
    public string name;
    public double price;
    public string category;
    public string brand;
    public string country;
}
class Program
{
    static void Main()
    {
        Product[] p = new Product[10];
        int count = 0;
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.Show Products");
            Console.WriteLine("3.Total Store Worth");
            Console.WriteLine("4.Exit");
           choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                p[count] = new Product();
                Console.Write("ID: ");
                p[count].id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                p[count].name = Console.ReadLine();
                Console.Write("Price: ");
                p[count].price = double.Parse(Console.ReadLine());
                Console.Write("Category: ");
                p[count].category = Console.ReadLine();
                Console.Write("Brand: ");
                p[count].brand = Console.ReadLine();
                Console.Write("Country: ");
                p[count].country = Console.ReadLine();
                count++;
            }
            else if (choice == 2)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(p[i].id + " " + p[i].name + " " + p[i].price);
                }
            }
            else if (choice == 3)
            {
                double total = 0;
              for (int i = 0; i < count; i++)
                {
                    total += p[i].price;
                }
                Console.WriteLine("Total Store Worth: " + total);
            }
        }
    }
}