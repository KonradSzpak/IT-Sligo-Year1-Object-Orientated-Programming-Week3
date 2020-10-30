using System;

namespace Year2Sem1Lab3Ex5
{
    class Program
    {
        static int stockOnHand;
        static void Main(string[] args)
        {
            
            int salesFigure;
            bool result1;

            Console.Write("Enter stock on hand: ");
            stockOnHand = int.Parse(Console.ReadLine());
            Console.WriteLine("stock on hand is " + stockOnHand);
            Console.Write("Enter salesFigure: ");
            salesFigure = int.Parse(Console.ReadLine());


            
            result1 = Method1(stockOnHand, salesFigure);
            
            Console.Write("has it been updated ?  "+result1+"\n");

            Console.Write("new stock on hand firgure "+stockOnHand + "\n");

        }

        static public bool Method1(int stock, int sales)
        {
            int result1;

            if (stock > sales)
            {
                stockOnHand = stock - sales;
                return true;
            }
            else
            {
                stockOnHand = stock - sales;
                return false;
            }




        }




    }
}
