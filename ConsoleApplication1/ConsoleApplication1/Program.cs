using System;

class Program
{
    static void Main()
    {
        // Введення числа n
        Console.WriteLine("Enter a number:");
        int n = Convert.ToInt32(Console.ReadLine());

        // Обчислення факторіалу
        long factorial = CalculateFactorial(n);

        // Виведення результату
        Console.WriteLine($"The factorial of {n} is: {factorial}");
    }

    // Метод для обчислення факторіалу
    static long CalculateFactorial(int n)
    {
        // Перевірка чи n >= 0
        if (n < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
            return -1;
        }

        // Обчислення факторіалу циклом
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}