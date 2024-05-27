using System;

class Program
{
    static void Mean(double X, double Y, out double AMean, out double GMean)
    {
        if (X < 0 || Y < 0)
        {
            throw new ArgumentException("X и Y должны быть положительными числами.");
        }

        AMean = (X + Y) / 2;
        GMean = Math.Sqrt(X * Y);
    }

    static void Main()
    {
        try
        {
            Console.Write("Введите A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите C: ");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите D: ");
            double D = Convert.ToDouble(Console.ReadLine());

            double AMean, GMean;

            Mean(A, B, out AMean, out GMean);
            Console.WriteLine($"(A, B) - Среднее арифметическое: {AMean}, Среднее геометрическое: {GMean}");

            Mean(A, C, out AMean, out GMean);
            Console.WriteLine($"(A, C) - Среднее арифметическое: {AMean}, Среднее геометрическое: {GMean}");

            Mean(A, D, out AMean, out GMean);
            Console.WriteLine($"(A, D) - Среднее арифметическое: {AMean}, Среднее геометрическое: {GMean}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введено не числовое значение.");
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
