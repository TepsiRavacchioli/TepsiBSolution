using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TepsiBConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 8;
            string res = "";
            while (num > 0)
            {
                int resto = num % 2;
                res = resto + res;
                num = num / 2;
            }
            Console.WriteLine($" risultato {res}");
        }
    }
}
