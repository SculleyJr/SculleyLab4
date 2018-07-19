using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            bool runProgram = true;
            while (runProgram)
            {
                // Greets and collects data from user

                Console.WriteLine("Learn yor squares and cubes!");
                Console.WriteLine("Enter an integer:");
                int i = int.Parse(Console.ReadLine());

                // Creates a string array that is formated evenly to represent the table

                string header = "Number,Squared,Cubed";
                string[] headerArray = header.Split(',');
                Console.WriteLine($"{headerArray[0],-10}{headerArray[1],-10}{headerArray[2],-10}" );
                string o = "=====";
                Console.WriteLine($"{ o,-10}{o,-10}{o,-10}");
               

                
                // This "for loop" loops as many times as the users integer

                for (int p = 1; p <= i; p++)                           
                {
                    int square = p * p;
                    int cube = p * p * p;
                    Console.WriteLine($"{p,-10}{square,-10}{cube,-10}");               //the format is to match the header above
                }

                Console.WriteLine("Press Y to coninue:");
                string input = Console.ReadLine();
                if (input.ToLower() == "y")
                { runProgram = true; }
                else
                { runProgram = false; }




            }
              

        }
    }
}
