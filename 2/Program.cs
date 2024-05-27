using System;

class Program
{
    static void Main()
    {
        byte n = 1;
        byte i;
        try
        {
            // Блок checked теперь первый
            checked
            {
                for (i = 1; i < 10; i++) n *= i;
                Console.WriteLine("1: {0}", n); // Возможно возникновение исключения здесь
            }
            // Блок unchecked теперь второй
            unchecked
            {
                n = 1;
                for (i = 1; i < 10; i++) n *= i;
                Console.WriteLine("2: {0}", n); // Переполнение проигнорировано, будет выведено некорректное значение
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("возникло переполнение");
        }
    }
}
