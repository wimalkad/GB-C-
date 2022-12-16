#   Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    void WArray (int[] array)
    {
        Console.WriteLine("Массив:");
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    Console.WriteLine("Введите N (размер массива): ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] chisla = new int[N];
    int sch = 0;

    for(int i = 0; i<chisla.Length; i++)
    {
        chisla[i] = new Random().Next(0,999);
        if (chisla[i] % 2 == 0)
        {
            sch++;
        }
    }

    WArray(chisla);
    Console.WriteLine($"Количество четных чисел: {sch}");

#   Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

    Console.WriteLine("Введите N (размер массива): ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] chisla = new int[N];
    int sch = 0;

    for(int i = 0; i<chisla.Length; i++)
    {
        chisla[i] = new Random().Next(-10,10);
        if ((i+1) % 2 != 0)
        {
            sch = sch + chisla[i];
        }
    }

    WArray(chisla);
    Console.WriteLine($"Сумма чисел на нечет позициях: {sch}");

#   Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

    void WDArray (double[] array)
    {
        Console.WriteLine("Массив:");
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    Console.WriteLine("Введите N (размер массива): ");
    int N = Convert.ToInt32(Console.ReadLine());
    double[] chisla = new double[N];
    double min = 100000;
    double max = -10000;

    for(int i = 0; i<chisla.Length; i++)
    {
        chisla[i] = new Random().Next(0,50);
        if (chisla[i] < min)
        {
            min = chisla[i];
        }
        if (chisla[i] > max)
        {
            max = chisla[i];
        }
    }

    WDArray(chisla);
    Console.WriteLine($"Разница между минимальным и максимальным : {max-min}");