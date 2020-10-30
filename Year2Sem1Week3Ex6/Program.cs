using System;

namespace Year2Sem1Lab3Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int average1=0;
            int average2=0;
            int average3=0;
            int[,] reviews = new int[3, 3]
            {
                {0, 1, 2}, 
                {3, 4, 5},  
                {6, 7, 8}  
            };
            for (int row = 0; row <= 2; row++)
            {
                for (int col = 0; col <= 2; col++)
                {
                    if (row == 0)
                        average1 += reviews[row, col];
                    else if (row == 1)
                        average2 += reviews[row, col];
                    else if (row ==2)
                        average3 += reviews[row, col];
                }
            }
            //average1 = reviews[0, 0] + reviews[0, 1] + reviews[0, 2];
            //average2 = reviews[1, 0] + reviews[1, 1] + reviews[1, 2];
            //average3 = reviews[2, 0] + reviews[2, 1] + reviews[2, 2];
            Console.WriteLine(average1/3);
            Console.WriteLine(average2/3);
            Console.WriteLine(average3/3);
        }
    }
}
