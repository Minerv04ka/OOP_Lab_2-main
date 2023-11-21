using System;

class Program
{
    static void Main()
    {
        // Введення значень
        Console.Write("Введіть x1Min: ");
        double x1Min = double.Parse(Console.ReadLine());

        Console.Write("Введіть x1Max: ");
        double x1Max = double.Parse(Console.ReadLine());

        Console.Write("Введіть dx1: ");
        double dx1 = double.Parse(Console.ReadLine());

        Console.Write("Введіть x2Min: ");
        double x2Min = double.Parse(Console.ReadLine());

        Console.Write("Введіть x2Max: ");
        double x2Max = double.Parse(Console.ReadLine());

        Console.Write("Введіть dx2: ");
        double dx2 = double.Parse(Console.ReadLine());

        // Змінні для ітераційних обчислень
        double x1 = x1Min;
        double x2;
        double y;
        double product = 1; // Добуток від'ємних значень

        // Зовнішній цикл по x1
        while (x1 <= x1Max)
        {
            x2 = x2Min; // Ініціалізація x2

            // Внутрішній цикл по x2
            while (x2 <= x2Max)
            {
                // Розрахунок функції y
                y = Math.Cos(Math.Pow(Math.Exp((x1 + 2 * x2 + 9) / 0.666), 3));

                // Виведення на екран
                Console.WriteLine($"x1 = {x1}, x2 = {x2}, y = {y}");

                // Розрахунок добутку від'ємних значень
                if (y < 0)
                {
                    product *= y;
                }

                // Збільшення x2 на dx2
                x2 += dx2;
            }

            // Збільшення x1 на dx1
            x1 += dx1;
        }

        // Виведення добутку від'ємних значень
        Console.WriteLine($"Добуток від'ємних значень: {product}");

        // Очікування натискання клавіші перед завершенням
        Console.ReadKey();
    }
}
