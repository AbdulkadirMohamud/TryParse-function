using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse__function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string numInput = Console.ReadLine(); //10h
            int num = 0;

             bool success = int.TryParse(numInput, out num); //false

            if (success )
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Failed to convert !");
            }
            

            

            Console.ReadLine();
        }
    }
}
