using System;

class Program
{
    static void CalculateExpressionA(double x)
    {
        // Проверка на возможное деление на ноль
        if (x == -10)
        {
            throw new DivideByZeroException();
        }
        double y = (Math.Pow(x, 3) - 2) / (x + 10) + 4 * x;
        Console.WriteLine($"Результат выражения a: y = {y}");
    }

    static void CalculateExpressionB(double x)
    {
        // Проверка, что x положительное для логарифма
        if (x <= 0)
        {
            throw new ArgumentException("Логарифм определен только для положительных чисел.");
        }
        // Проверка на возможное деление на ноль
        if (x == -6)
        {
            throw new DivideByZeroException();
        }
        double y = Math.Log(x) + Math.Cos(x) / (x + 6);
        Console.WriteLine($"Результат выражения b: y = {y}");
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введите x для выражения a: ");
            double x = Convert.ToDouble(Console.ReadLine());
            CalculateExpressionA(x);

            Console.Write("Введите x для выражения b: ");
            x = Convert.ToDouble(Console.ReadLine());
            CalculateExpressionB(x);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: деление на ноль.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено не числовое значение.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
        }
    }
}
