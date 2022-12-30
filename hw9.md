# Задача 1

    static void func (int n)
    {
        if (n == 1)
        {
        Console.WriteLine (1);
        }
        else
        {
        func (n - 1);
        Console.WriteLine (n);
        }
    }

# Задача 2

    static int func(int m, int n)
    {
        if (m == n)
        {
            return m;
        }
        else
        {
            return m + func(m + 1, n);
        }
    }

# Задача 3

    static int func_acc(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return func_acc(m - 1, 1);
        }
        else
        {
            return func_acc(m - 1, func_acc(m, n - 1));
        }
    }
}
