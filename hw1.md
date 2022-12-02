#  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

    Console.WriteLine("Введите число a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a>b)
    {
        Console.WriteLine("Число " + a + " большее" + ", а число " + b + " меньшее");
    }
    else
    {
        Console.WriteLine("Число " + b + " большее" + ", а число " + a + " меньшее");
    }


# Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


    Console.WriteLine("Введите число a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число c: ");
    int c = Convert.ToInt32(Console.ReadLine());
    int max = a;

    if (b>max)
    {
        max = b;
    }
    if (c>max)
    {
        max = c;
    }
    Console.WriteLine("Максимальное число :" + max);

# Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


    Console.WriteLine("Введите число a: ");
    int a = Convert.ToInt32(Console.ReadLine());

    if (a % 2 == 0)
    {
        Console.WriteLine("Число четное");
    }
    else
    {
        Console.WriteLine("Число нечетное");
    }

# Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

    Console.WriteLine("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    if (N>0)
    {
            int i = 1;
            Console.WriteLine("Все четные числа до N: ");
            while (i<N)
        {
            if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
        i++;
    }
    }
