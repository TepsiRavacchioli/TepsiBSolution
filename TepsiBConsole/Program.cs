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
            int num = 123;
            string res = "";
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
            Console.WriteLine($" risultato {res}");
        }
    }
}
