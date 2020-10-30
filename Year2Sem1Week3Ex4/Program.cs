using System;

namespace Year2Sem1Lab3Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;


            Console.WriteLine("enter");

            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter2");

            num2 = int.Parse(Console.ReadLine());

            Sum(num1, num2);
        }
        static void Sum(int n1, int n2)
        {
            if (n1 / 2 == 0 && n2 / 2 == 0)
            {
                int length2Even = (n2 - n1) / 2;

                for(int i=0; length2Even )
            }
            else if (n1 / 2 != 0 && n2 / 2 == 0)
            {
                int lengthN1Odd = ((n2 - n1) - 1) / 2;
            }
            else if (n1 / 2 == 0 && n2 / 2 != 0)
            {
                int lengthN1Odd = ((n2 - n1) - 1) / 2;
            }
            else
            {
                int length2Even = (n2 - n1) / 2;
            }


            
        }
    }
}
