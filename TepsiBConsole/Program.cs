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
            int num = 0;
            string res = "";
            int toBase = 0;
            Console.WriteLine("inserisci un numero intero in base 10 ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Scegli la base in cui convertire il numero tra 2 e 16 ");
            toBase = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                int resto = num % toBase;
                res = resto + res;
                num = num / toBase;
            }
            Console.WriteLine($" risultato conversione di {num} in base {toBase}: {res}");
        }
    }
}
