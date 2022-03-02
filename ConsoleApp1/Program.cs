using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 != 0)
            {
                string str = new String('*', n);
                string str_1 = "";
                Console.WriteLine(str);
                int i = 0;
                int midle = Convert.ToInt32(Math.Round(Convert.ToDouble(n / 2)));
                while (i != n - 2)
                {
                    if (i == midle - 1)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (j == midle)
                            {
                                str_1 += " ";
                            }
                            else
                            {
                                str_1 += "*";
                            }
                        }
                        Console.WriteLine(str_1);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine(str);
                        i++;
                    }
                }
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("Введите нечетное число");
            }
            Console.ReadKey();
        }
    }
}
