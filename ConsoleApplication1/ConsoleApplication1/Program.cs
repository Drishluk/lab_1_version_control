// Поліпшення коду
// Основні зміни:
// 1. Використання int.TryParse для уникнення винятків, коли користувач вводить некоректне значення.
// 2. Додано обробку негативних чисел через виняток ArgumentException.
// 3. Додано рекурсивний метод для обчислення факторіалу.
// 4. Програма працює в циклі while, який продовжує виконуватися, поки змінна continueProgram дорівнює true.
// 5. Після кожного обчислення запитуємо користувача, чи хоче він продовжити обчислення.
// Якщо відповідь "no" або щось інше, програма завершується.

using System;

class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Enter a number:");

            // Безпечний ввід числа
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                try
                {
                    // Обчислення факторіалу
                    long factorial = CalculateFactorial(n);

                    // Виведення результату
                    Console.WriteLine($"The factorial of {n} is: {factorial}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Перевірка, чи хоче користувач продовжити
            Console.WriteLine("Do you want to calculate another factorial? (yes/no)");
            string userInput = Console.ReadLine().ToLower();

            if (userInput != "yes" && userInput != "y")
            {
                continueProgram = false;
            }
        }

        Console.WriteLine("Exiting program. Goodbye!");
    }

    // Метод для обчислення факторіалу
    static long CalculateFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Factorial is not defined for negative numbers.");
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
