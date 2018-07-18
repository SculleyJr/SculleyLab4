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
                Console.WriteLine("Learn yor squares and cubes!");
                Console.WriteLine("Enter and integer:");
                int i = int.Parse(Console.ReadLine());

                string header = "Number,Squared,Cubed";
                string[] headerArray = header.Split(',');
                Console.WriteLine($"{headerArray[0],-10}{headerArray[1],-10}{headerArray[2],-10}" );
                string o = "=====";
                Console.WriteLine($"{ o,-10}{o,-10}{o,-10}");
               

                
                

                for (int p = 1; p <= i; p++)
                {
                    int square = p * p;
                    int cube = p * p * p;
                    Console.WriteLine($"{p,-10}{square,-10}{cube,-10}");
                }

                Console.WriteLine("Press Y to coninue:");
                string input = Console.ReadLine();
                if (String.Equals(input, "Y"))
                { runProgram = true; }
                else
                { runProgram = false; }





            }
              

        }
    }
}
