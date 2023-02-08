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
                int resto = num % 16;
                string alfa = "";
                switch (resto)
                {
                    case 10:
                        alfa = "A";
                        break;
                    case 11:
                        alfa = "B";
                        break;
                    case 12:
                        alfa = "C";
                        break;
                    case 13:
                        alfa = "B";
                        break;
                    case 14:
                        alfa = "E";
                        break;
                    case 15:
                        alfa = "F";
                        break;
                    default:
                        alfa = alfa +resto;
                        break;
                }
                res = alfa + res;
                num = num / 16;
            }
            Console.WriteLine($" risultato conversione di {num} in base {toBase}: {res}");
        }
    }
}
