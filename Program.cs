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

void WDArray (double[] array)
{
    Console.WriteLine("Массив:");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

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