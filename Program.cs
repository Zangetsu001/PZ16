using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {14,54,2,5,76,23,765 };
            foreach(var el in list)
            {
                if(el % 5 == 0)
                {
                    Console.WriteLine(el);
                }
            }
            Console.ReadKey();
        }

    }
}
