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

#   Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

    void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            {        
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array [i,j] = new Random().Next(1, 5);
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

    Console.WriteLine("введите количество строк первой матрицы:");
    int lines1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов первой матрицы:");
    int columns1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите количество столбцов второй матрицы:");
    int columns2 = Convert.ToInt32(Console.ReadLine());


    int[,] firstMartrix = new int[lines1, columns1];
    FillArrayRandomNumbers(firstMartrix);
    Console.WriteLine($"\nПервая матрица:");
    PrintArray(firstMartrix);

    int[,] secomdMartrix = new int[columns1, columns2];
    FillArrayRandomNumbers(secomdMartrix);
    Console.WriteLine($"\nВторая матрица:");
    PrintArray(secomdMartrix);

    int[,] proizvmatrix = new int[lines1,columns2];

    MultiplyMatrix(firstMartrix, secomdMartrix, proizvmatrix);
    Console.WriteLine($"\nПроизведение первой и второй матриц:");
    PrintArray(proizvmatrix);

    void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
    {
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
        int sum = 0;
        for (int q = 0; q < firstMartrix.GetLength(1); q++)
        {
            sum += firstMartrix[i,q] * secomdMartrix[q,j];
        }
        resultMatrix[i,j] = sum;
        }
    }
    }

#   Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

    Console.WriteLine("nВведите размер массива X x Y x Z:");
    Console.WriteLine("введите X:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите Y:");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите Z:");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"");

    int[,,] arrayob = new int[x, y, z];
    FillArray(arrayob);
    PrintArray(arrayob);


    void PrintArray (int[,,] array3D)
    {
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
        Console.Write($"X({i+1}) Y({j+1}) ");
        for (int k = 0; k < array3D.GetLength(2); k++)
        {
            Console.Write( $"Z({k+1})={array3D[i,j,k]}; ");
        }
        Console.WriteLine();
        }
        Console.WriteLine();
    }
    }

    void FillArray(int[,,] array3D)
    {
    int[] vrem = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int  number;
    for (int i = 0; i < vrem.GetLength(0); i++)
    {
        vrem[i] = new Random().Next(10, 100);
        number = vrem[i];
        if (i >= 1)
        {
        for (int j = 0; j < i; j++)
        {
            while (vrem[i] == vrem[j])
            {
            vrem[i] = new Random().Next(10, 100);
            j = 0;
            number = vrem[i];
            }
            number = vrem[i];
        }
        }
    }
    int count = 0; 
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
        for (int z = 0; z < array3D.GetLength(2); z++)
        {
            array3D[x, y, z] = vrem[count];
            count++;
        }
        }
    }
    }
