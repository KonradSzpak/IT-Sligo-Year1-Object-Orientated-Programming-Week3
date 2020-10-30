using System;

namespace Year2Sem1Lab3Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string product;
            double price;
            Console.WriteLine("What do u want (if error cost = -999)");
            product  =Console.ReadLine().ToLower();

            price = GetPriceOfProduct(product);

            Console.WriteLine(price);
        }


        private static double GetPriceOfProduct(string product)
        {

            switch(product)
            {
                case "jeans":
                    return 67.99;
                case "jacket":
                    return 68.99;
                case "boots":
                    return 34.99;
                case "scarves":
                    return 10;
                case "belts":
                    return 10;
                case "socks":
                    return 10;
                default:
                    return -999;
            }

        }
    }
}
