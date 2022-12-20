#   Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    Console.WriteLine("Введите количество чисел N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int sch = 0;
    Console.WriteLine("Введите числа: ");
    for(int i =0; i < N; i++)
    {
        int chislo = Convert.ToInt32(Console.ReadLine ());
        if (chislo > 0)
        {
            sch++;
        }
    }
    Console.WriteLine($"Количество положительных чисел: {sch}");

Данная задача аналогично делается через одномерный массив, пользователь задает длину массива, а дальше через цикл for до конца длины массива вводятся числа и заносится их количество в отдельную переменную. Чтобы не нагружать оперативную память лишним выделением ячеек в памяти, предлагаю решать через for. Могу быть неправ, поэтому буду рад если поправите в комментариях к дз.

#   Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

    Console.WriteLine("Введите переменную b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите переменную k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите переменную b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите переменную k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Координаты точки пересечения X = {x} Y = {y} ");