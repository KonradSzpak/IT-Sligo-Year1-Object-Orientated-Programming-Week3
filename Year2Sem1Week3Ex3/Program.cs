using System;

namespace Year2Sem1Lab3Ex3
{
    class Program
    {
        static void Main()
        {

            int[] ten = { };

            Zero0(ten);
        }

        static void Zero0(int[] ten)
        {
            for (int i = 0; i < 10; i++)
            {
                ten[i] = 0;
            }
            for (int j = 0; j < 10; j++)
            {
                Console.Write(ten[j]);
            }
        }
        



        
    }
}
