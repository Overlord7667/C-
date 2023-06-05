using System;


namespace arifmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            

            Console.WriteLine("Введите первое число");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue);
            Console.WriteLine( " sum of two numbers =  " + result );

            double result2 = (firstValue + secondValue) / 2;
            Console.WriteLine(" the arifmetic mean of this number =  " + result2);
            Console.WriteLine("Для завершения нажмите Enter ");
            Console.ReadLine();
        }
    }
}
