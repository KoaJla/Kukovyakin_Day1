using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static string getSequence(int number)
        {
            string result = "";

            for (int i = 0; i <= number; i++)
            {
                result += i + " ";
            }
            return result;
        }

        static void getResult(string result)
        {
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            string result;
            Console.WriteLine("Введите число");
            try
            {
                int number = int.Parse(Console.ReadLine());
                result = getSequence(number);
                getResult(result);
            }
            catch
            {
                Console.WriteLine("Вы ввели неверное значение");
            }
            Console.ReadLine();
        }
    }
}
