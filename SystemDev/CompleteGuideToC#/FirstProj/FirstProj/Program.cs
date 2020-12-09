using System;

namespace FirstProj
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 3, sumInt = 0;            
            float c = 1.3f, d = 12.9f, sumFloat = 0;
            double e = 0, f = 2.3, sumDouble = 0;

            sumInt = a + b;
            sumFloat = c + d;
            sumDouble = e + f;

            Console.WriteLine(sumInt);
            Console.WriteLine(sumFloat);
            Console.WriteLine(sumDouble);

            // Test with read line.

            double firstNumber = 0, secondNumber = 0, sum = 0;
            Console.WriteLine("Please add first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please add second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            sum = firstNumber + secondNumber;
            Console.WriteLine("Sum is: "+ sum);
        }
    }
}
