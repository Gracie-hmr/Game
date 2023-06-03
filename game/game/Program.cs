
using System;

class Program
{
    public static int generatorNum(int number)
    {
        Random rnd = new Random();
        int RundNumber = rnd.Next(0, number);
        return RundNumber;
    }
    public static void Main(string[] args)
    {
        int num1, num2 = 0;
        int i = 1;
        int attempt = 2;
        Console.WriteLine("Как вас зовут?");
        string name = Console.ReadLine();
        Console.WriteLine("Здравствуйте, " + name);
        Console.WriteLine("Ваша задача складывать выпадающие числа. Всего 5 раундов.");
        while (i <= 5)
        {
            if (attempt >= 0)
            {
                num1 = generatorNum(100);
                num2 = generatorNum(100);
                Console.WriteLine($"Сложите числа {num1} и {num2}.");
                string userNumStr = Console.ReadLine();
                int userNumInt = Int32.Parse(userNumStr);
                if (userNumInt == num1 + num2)
                {
                    Console.WriteLine($"Ответ правильный! Раунд {i} пройден!");
                    Console.WriteLine();
                    i += 1;
                }
                else
                {
                    Console.WriteLine($"Ответ неправильный! У вас осталось {attempt} попытки!");
                    Console.WriteLine();
                    attempt -= 1;
                }
                if (i == 6)
                {
                    Console.WriteLine($"{name}, вы выиграли!");
                }
            }
            else
            {
                Console.WriteLine($"Попытки закончились! {name}, вы проиграли!");
                i = 10;
            }
            
        }
        // num1 = generatorNum(100);
        // num2 = generatorNum(100);
        // Console.WriteLine (num1);
        // Console.WriteLine (num2);
        // Console.WriteLine (generatorNum(100));
    }
}
