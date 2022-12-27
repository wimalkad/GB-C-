#   Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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


    Console.WriteLine("введите количество строк:");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());
    int [,] numbers = new int [lines,columns];
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);
    for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                for (int q = 0; q < numbers.GetLength(1) - 1; q++)
                {
                    if (numbers[i, q] < numbers[i, q + 1])
                    {
                        int vrem = numbers[i, q + 1];
                        numbers[i, q + 1] = numbers[i, q];
                        numbers[i, q] = vrem;
                    }
                }
            }
        }
    Console.WriteLine("Отсортированный массив:");
    PrintArray(numbers);

#   Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            {        
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array [i,j] = new Random().Next(0, 10);
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

    int SumStroki(int[,] array, int i)
    {
    int sumstr = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumstr += array[i,j];
    }
    return sumstr;
    }

    Console.WriteLine("введите количество строк:");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());
    int [,] numbers = new int [lines,columns];
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);

    int sum = 0;
    int summastroki = SumStroki(numbers, 0);

    for (int i = 1; i < numbers.GetLength(0); i++)
    {
    int vremSumLine = SumStroki(numbers, i);
    if (summastroki> vremSumLine)
    {
        summastroki = vremSumLine;
        sum = i;
    }
    }

    Console.WriteLine($"{sum+1} - номер строки с наименьшей суммой: {summastroki}");

    PrintArray(numbers);


#   Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


    int n = 4;
    int[,] sqareMatrix = new int[n, n];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
    {
    sqareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
    }

    PrintArray(sqareMatrix);

    void PrintArray (int[,] array)
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        if (array[i,j] / 10 <= 0)
        Console.Write($" {array[i,j]} ");

        else Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    }
