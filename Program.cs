/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

/*Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
Console.WriteLine("Число " + a + " большее" + ", а число " + b + " меньшее");
else
Console.WriteLine("Число " + b + " большее" + ", а число " + a + " меньшее"); */


/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

/* Console.WriteLine("Введите число a: ");
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
Console.WriteLine("Максимальное число :" + max);*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

/*Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

/*Console.WriteLine("Введите число N: ");
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
}*/

/* Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());

int stepen = a;

for (int i = 0; i < b-1; i++)
{
    stepen *= a;
    Console.WriteLine(stepen +" "+ a);
}

Console.WriteLine($"Итоговое число: {stepen}");*/

/*Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());

int summa = 0;

while(a>0)
{
    summa = summa + a % 10;
    a = a/10;
}
Console.WriteLine($"Сумма цифр числа {summa}");*/

/*Console.WriteLine("Введите N (размер массива): ");
int N = Convert.ToInt32(Console.ReadLine());
int[] chisla = new int[N];

for(int i = 0; i<chisla.Length; i++)
{
    chisla[i] = new Random().Next(0,999);
}

WArray(chisla);*/


/*void WArray (int[] array)
{
    Console.WriteLine("Массив:");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}*/

/*void WDArray (double[] array)
{
    Console.WriteLine("Массив:");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}*/

/*Console.WriteLine("Введите N (размер массива): ");
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
Console.WriteLine($"Количество четных чисел: {sch}");*/

/*Console.WriteLine("Введите N (размер массива): ");
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
Console.WriteLine($"Сумма чисел на нечет позициях: {sch}");*/

/* Console.WriteLine("Введите N (размер массива): ");
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
Console.WriteLine($"Разница между минимальным и максимальным : {max-min}"); */

/*Console.WriteLine("Введите количество чисел N: ");
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
Console.WriteLine($"Количество положительных чисел: {sch}");*/

/*Console.WriteLine("Введите переменную b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2-b1)/(k1-k2);
double y = k1 * x + b1;

Console.WriteLine($"Координаты точки пересечения X = {x} Y = {y} ");*/


/*Console.WriteLine("введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[lines, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}*/

/*Console.WriteLine("введите количество строк:");
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
    }*/

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

/*Console.WriteLine("введите количество строк:");
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
*/

// Задача 62: Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

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

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
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