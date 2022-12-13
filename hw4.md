#   Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

    Console.WriteLine("Введите число : ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень числа: ");
    int b = Convert.ToInt32(Console.ReadLine());

    int stepen = a;

    for (int i = 0; i < b-1; i++)
    {
        stepen *= a;
    }

    Console.WriteLine($"Итоговое число: {stepen}");

#   Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    Console.WriteLine("Введите число : ");
    int a = Convert.ToInt32(Console.ReadLine());

    int summa = 0;

    while(a>0)
    {
        summa = summa + a % 10;
        a = a/10;
    }
    Console.WriteLine($"Сумма цифр числа {summa}");

#   Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.

    Console.WriteLine("Введите N (размер массива): ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] chisla = new int[N];

    for(int i = 0; i<chisla.Length; i++)
    {
        chisla[i] = new Random().Next(0,999);
    }

    WArray(chisla);


    void WArray (int[] array)
    {
        Console.WriteLine("Массив:");
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }