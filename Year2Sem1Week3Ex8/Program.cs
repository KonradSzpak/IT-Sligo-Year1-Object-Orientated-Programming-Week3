using System;
using System.Collections.Generic;
using System.IO;

namespace Year2Sem1Lab3Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> team = new List<string>();



            Console.Write("enter: ");
            string input = Console.ReadLine();

            while (input != "-1")
            {
                team.Add(input);

                Console.Write("enter: ");
                input = Console.ReadLine();
            }

            foreach (string person in team)
            {
                Console.WriteLine(person);
            }

        }
    }
}
