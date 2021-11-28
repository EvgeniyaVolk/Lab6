using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            start = start.Replace(" ", "");
            char[] array = start.ToCharArray();
            Array.Reverse(array);
            string reverse = new string(array);

            if (start == reverse)
            {
                Console.WriteLine("Данная надпись является палиндромом");
            }
            else
            {
                Console.WriteLine("Данная надпись не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
