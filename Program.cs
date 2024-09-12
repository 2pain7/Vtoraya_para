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
            Console.WriteLine("Введите строку");
            string stroka = Console.ReadLine();
            Split(stroka);
        }
        static void Split (string name)
        {
            int Index = name.IndexOf('.');
            if (Index >= 0)
            {
                string name1 = name.Substring(0, Index);
                string name2 = name.Substring(Index + 1);
                Console.WriteLine($"Первая строка:{name1} ; Вторая строка {name2} ;");
            }
            else
            {
                Console.WriteLine($" В строке нет точки:{name}");
            }
        }
    }
}
