#   Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    Console.WriteLine("введите количество строк: ");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] numbers = new double[lines, columns];


        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().NextDouble();
            }
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine("");
        }

#   Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
    Console.WriteLine("введите количество строк:");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите позицию по строке:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите позицию по столбцу:");
    int y = Convert.ToInt32(Console.ReadLine());

    int [,] numbers = new int [lines,columns];
    FillArrayRandomNumbers(numbers);

    if (x > numbers.GetLength(0) || y > numbers.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет!");
    }
    else
    {
        Console.WriteLine($"Значение элемента равно: {numbers[x-1,y-1]}");
    }

    PrintArray(numbers);

    void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            {        
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array [i,j] = new Random().Next(0, 100);
                }   
            }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i,j] + " ");
            }   
            Console.WriteLine(""); 
        }
    }

#   Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    Console.WriteLine("введите количество строк:");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());
    int [,] numbers = new int [lines,columns];
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);
    double sum = 0;
    double avg = 0;
    Console.WriteLine("Среднее арифметическое по столбцам");
    for (int i = 0; i < numbers.GetLength(1); i++)
        {        
            for (int j = 0; j < numbers.GetLength(0); j++)
            {
            sum += numbers[j,i];
            }
            avg = sum/numbers.GetLength(0);
            Console.Write(avg + " ");
            sum = 0;
            avg = 0;   
        }

    void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            {        
                for (int j = 0; j < array.GetLength(1); j++)
                {
                 array [i,j] = new Random().Next(0, 20);
                }   
            }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i,j] + " ");
            }   
            Console.WriteLine(""); 
        }
    }