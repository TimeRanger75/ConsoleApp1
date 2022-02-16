using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int szam = rand.Next(1, 7);
            Console.WriteLine(szam);
            Console.ReadKey();
        }
    }
}
