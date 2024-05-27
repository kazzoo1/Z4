using System;

class Program
{
    static double CalculateFunction(double x)
    {
        // Проверка диапазона и генерация пользовательского исключения
        if (x <= 0)
        {
            throw new ArgumentException("x должен быть больше 0.");
        }
        if (x == 1)
        {
            throw new DivideByZeroException("Выражение не определено при x = 1.");
        }

        if (x < 1)
        {
            return 3 * Math.Pow(x, 2); // 3x^2 для 0 < x < 1
        }
        else
        {
            return x / (x - 1); // x / (x-1) для x >= 1
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double result = CalculateFunction(x);
            Console.WriteLine($"Значение функции f: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введенное значение не является числом.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
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
