using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.TaxiCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtKm = 0;
            Console.WriteLine("Ente the leght of path: ");
            lenghtKm = int.Parse(Console.ReadLine());

            if (lenghtKm < 2)
            {
                Console.WriteLine("Your fare is: ");
            }
        }
    }
}
