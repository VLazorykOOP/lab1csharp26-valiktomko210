using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування для коректного відображення українських літер в консолі
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n--- Оберіть завдання (1-6) або 0 для виходу ---");
                Console.Write("Ваш вибір: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Task1_20(); break;
                    case "2": Task2_20(); break;
                    case "3": Task3_20(); break;
                    case "4": Task4_19(); break; 
                    case "5": Task5_20(); break;
                    case "6": Task6_2(); break;
                    case "0": return;
                    default: Console.WriteLine("Невірний вибір, спробуйте ще раз."); break;
                }
            }
        }

        // ЗАВДАННЯ 1.20: Сума геометричної прогресії
        static void Task1_20()
        {
            Console.WriteLine("\n--- Завдання 1.20 ---");
            Console.Write("Введіть перший член прогресії (b1): ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("Введіть знаменник прогресії (q): ");
            double q = double.Parse(Console.ReadLine());
            Console.Write("Введіть кількість членів (n): ");
            int n = int.Parse(Console.ReadLine());

            double sum = (q == 1) ? b1 * n : b1 * (1 - Math.Pow(q, n)) / (1 - q);
            Console.WriteLine($"Сума перших {n} членів геометричної прогресії: {sum}");
        }

        // ЗАВДАННЯ 2.20: Чи є трикутник рівностороннім
        static void Task2_20()
        {
            Console.WriteLine("\n--- Завдання 2.20 ---");
            Console.Write("Введіть сторону a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введіть сторону b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введіть сторону c: ");
            double c = double.Parse(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0 && (a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine(a == b && b == c ? "Трикутник є рівностороннім." : "Трикутник НЕ є рівностороннім.");
            }
            else Console.WriteLine("Трикутник із такими сторонами не існує.");
        }

        // ЗАВДАННЯ 3: Точка у заштрихованій області (Мал. 20)
        static void Task3_20()
        {
            Console.WriteLine("\n--- Завдання 3 (Область №20) ---");
            Console.Write("Введіть x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введіть y: ");
            double y = double.Parse(Console.ReadLine());

            if (y > 0 && y < 23 && x > -y && x < 0) Console.WriteLine("Так");
            else if (y < 0 || y > 23 || x < -y || x > 0) Console.WriteLine("Ні");
            else Console.WriteLine("На межі");
        }

        // ЗАВДАННЯ 4.19: Ознака геометричної фігури
        static void Task4_19()
        {
            Console.WriteLine("\n--- Завдання 4.19 ---");
            Console.Write("Введіть ознаку фігури (к - коло, п - прямокутник, т - трикутник): ");
            string code = Console.ReadLine().ToLower().Trim();

            if (code == "к") {
                Console.Write("Радіус: "); double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"Периметр: {2 * Math.PI * r:F2}, Площа: {Math.PI * r * r:F2}");
            }
            else if (code == "п") {
                Console.Write("Сторона А: "); double sideA = double.Parse(Console.ReadLine());
                Console.Write("Сторона B: "); double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine($"Периметр: {2 * (sideA + sideB):F2}, Площа: {sideA * sideB:F2}");
            }
            else if (code == "т") {
                Console.Write("Сторона a: "); double tA = double.Parse(Console.ReadLine());
                Console.Write("Сторона b: "); double tB = double.Parse(Console.ReadLine());
                Console.Write("Сторона c: "); double tC = double.Parse(Console.ReadLine());
                double p = tA + tB + tC, p2 = p / 2;
                Console.WriteLine($"Периметр: {p:F2}, Площа: {Math.Sqrt(p2 * (p2 - tA) * (p2 - tB) * (p2 - tC)):F2}");
            }
            else Console.WriteLine("Невідома фігура.");
        }

        // ЗАВДАННЯ 5.20: Куб добутку двох цілих чисел
        static void Task5_20()
        {
            Console.WriteLine("\n--- Завдання 5.20 ---");
            Console.Write("Число 1: "); int n1 = int.Parse(Console.ReadLine());
            Console.Write("Число 2: "); int n2 = int.Parse(Console.ReadLine());
            long prod = (long)n1 * n2;
            Console.WriteLine($"Куб добутку: {prod * prod * prod}");
        }

        // ЗАВДАННЯ 6.2: Обчислення математичного виразу
        static void Task6_2()
        {
            Console.WriteLine("\n--- Завдання 6.2 ---");
            Console.Write("Введіть x: "); double x = double.Parse(Console.ReadLine());
            Console.Write("Введіть y: "); double y = double.Parse(Console.ReadLine());

            if (x * y == 0) Console.WriteLine("Помилка: ділення на нуль.");
            else Console.WriteLine($"Результат: {(1.0 / (x * y) + 1.0 / (x * x + 1)) * (x + y)}");
        }
    }
}