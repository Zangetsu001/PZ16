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
            List<string> list = new List<string>() {"Овен","Телец","Близнецы","Рак","Лев","Дева" };
            Output(list);
            Capslook(list);
            Console.WriteLine($"Количество элементов значения: {list.Count}");
            list.Add("Весы");
            Output(list);
            list.Insert(0, "Стерелец");
            Output(list);
            list.RemoveAt(3);
            Output(list);
            Console.ReadKey();
        }
        static void Output(List<string>list)
        {
            foreach(var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }
        static void Capslook(List<string> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i.ToUpper());
            }
            Console.WriteLine();
        }
        

    }

}
