using System;

namespace Year2Sem1Lab3Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string result1;

            Console.Write("Enter Age: ");
            age = int.Parse(Console.ReadLine());

            

            result1 = CheckAge(age);
            Console.WriteLine(result1);
        }

        private static string CheckAge(int age)
        {
            if (age >= 18 && age <= 21)
                return "acces allowed";
            else
                return "get out of here dude";

            
        }


    }
}
