using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string[] array = start.Split();
            int n = 1;
            int t = 1;
                for (int j = 0; j < array.Count(); j++)
                {
                    n = array[j].Length;
                    if (n>t)
                    {
                        t = n;
                    }
                Console.WriteLine("Длина {0} слова = {1}",j, n);

                 }

            Console.WriteLine("Максимальная длина слова = {0} букв", t);
            Console.ReadKey();

        }
    }
}
