using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод чисел a и b
        Console.WriteLine("Введите числа a и b:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        // Вызов функции для нахождения НОД и коэффициентов x и y
        int gcd = GCD(a, b, out int x, out int y);

        // Вывод результатов
        Console.WriteLine($"НОД: {gcd}");
        Console.WriteLine($"x: {x}");
        Console.WriteLine($"y: {y}");
    }

    // Функция для нахождения НОД и коэффициентов x и y
    static int GCD(int a, int b, out int x, out int y)
    {
        if (b == 0)
        {
            x = 1;
            y = 0;
            return a;
        }

        int x1, y1;
        int gcd = GCD(b, a % b, out x1, out y1);

        x = y1;
        y = x1 - (a / b) * y1;

        return gcd;
    }
}