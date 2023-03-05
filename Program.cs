using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int multiple = 3;
            int multiple2 = 5;
            int minimumRandomValue = 0;
            int maximumRandomValue = 101;
            int maxNumber = random.Next(minimumRandomValue, maximumRandomValue);
            int sum = 0;

            for (int i = multiple; i <= maxNumber; i++)
            {
                if (i % multiple == 0 && i % multiple2 == 0)
                {
                    sum += i;
                }
            }
           
            Console.WriteLine(" Рандомное число " + maxNumber + " Сумма всех чисел кратных " + multiple + " или " + multiple2 + " до " + maxNumber + " равна " + sum);
        }
    }
}