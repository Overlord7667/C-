using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double USDToRUB = 122.12;
            double USDToCNY = 6.36;
            double USD;

            Console.WriteLine("Введите сумму в USD ");

            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + " USD в RUB = " + USD * USDToRUB);
            Console.WriteLine(USD + " USD в CNY = " + USD * USDToCNY);
            Console.WriteLine("Для завершения нажмите Enter ");
            Console.ReadLine();
        }
    }
}
