using System;
using ProductCatalog.Entities;

namespace ProductCatalog
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Product-Catalog");
            Console.WriteLine("1.PRODUCT");
            Console.WriteLine("2.CATEGORY");
            Console.WriteLine("3.EXIT-APP");

            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '1':
                    ProductOperations.ProductOperationMenu();
                    break;
                case '2':
                    CategoryOperations.CategoryOperationMenu();
                    break;
                case '3':
                    break;
                default:
                    Console.WriteLine("Please Enter Valid Options");
                    break;
            }
        }

    }
}
