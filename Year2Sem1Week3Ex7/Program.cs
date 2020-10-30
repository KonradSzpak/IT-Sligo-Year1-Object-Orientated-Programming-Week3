using System;


namespace Year2Sem1Lab3Ex7

{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagArray =
            {
                new int[] { 3, 4},
                new int[] { 1, 2, 1, 3 },               //declaring jaggArray
                new int[] { 5, 4,2 }
            };

            double[] averages = new double[3]; //declares array, 
            int total = 0;

            for (int i = 0; i < jagArray.GetLength(0); i++) //for every number in "0"th row of the array do below
            {
                total = 0; //resets the total for the next row

                for (int j = 0; j < jagArray[i].Length; j++) //for length of each row do this
                {
                    total += jagArray[i][j]; // [0][0] + [0][1] + [0][2] = total 
                }
                averages[i] = (double)total / jagArray[i].Length;    //averages[0] = total / jagArray[0].Length // divides total by amount of numbers in the first row
            }


            foreach (double average in averages)
            {
                Console.WriteLine($"{average:F2}");
            }


        }
    }
}
