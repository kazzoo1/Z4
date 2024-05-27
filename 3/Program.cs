using System;

class Program
{
    static void Main()
    {
        try
        {
            int f = 1;
            for (int i = 1; i <= 10; i++)
            {
                f *= i;
                if (f - 1 < 0.000001)
                {
                    throw new DivideByZeroException("Значение f-1 слишком мало, что эквивалентно делению на ноль.");
                }
                Console.WriteLine($"Факториал {i} = {f}");
            }
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
