using System;

class Program
{
    static void Main()
    {
        byte x = 200;
        byte y = 200;
        try
        {
            // В данном случае не используем ключевое слово unchecked
            byte result = (byte)(x + y);
            Console.WriteLine("1: {0}", result); // Будет выведено значение 144 из-за переполнения
            result = checked((byte)(x + y)); // Здесь произойдет переполнение и исключение
            Console.WriteLine("2: {0}", result);
        }
        catch (OverflowException)
        {
            Console.WriteLine("возникло переполнение"); // Это сообщение будет выведено
        }
    }
}
