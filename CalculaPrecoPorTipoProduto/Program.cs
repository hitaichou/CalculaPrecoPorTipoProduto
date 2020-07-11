using System;
using System.Collections.Generic;
using CalculaPrecoPorTipoProduto.Entities;
using System.Globalization;
namespace CalculaPrecoPorTipoProduto
    
{
    class Program
    {
        /*
            Fazer um programa para ler os dados de N produtos (N fornecido pelo usuário). Ao final,
            mostrar a etiqueta de preço de cada produto na mesma ordem em que foram digitados.
            Todo produto possui nome e preço. Produtos importados possuem uma taxa de alfândega, e
            produtos usados possuem data de fabricação. 
            Estes dados específicos devem ser acrescentados na etiqueta de preço conforme
            exemplo (próxima página). Para produtos importados, a taxa e alfândega deve ser
            acrescentada ao preço final do produto. 
        */
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of product: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product {i} data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                char tp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tp == 'i')
                {
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //lanço na lista a entrada do produto com imposto
                    list.Add(new ImportedProduct(name, price, customFee));
                }
                else if (tp == 'u')
                {
                    Console.Write("Manufacture date: ");
                    DateTime dtManufacture = DateTime.Parse(Console.ReadLine());

                    //lanço na lista a entrada do produto com data
                    list.Add(new UsedProduct(name, price, dtManufacture));
                }
                else
                {
                    list.Add(new Product(name, price));
                }

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");

            foreach(Product prd in list)
            {
                Console.WriteLine(prd.PriceTag());
            }
        }
    }
}
