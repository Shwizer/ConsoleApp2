using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static bool IsPerfectNumber(int n)
    {
        if (n <= 1) return false;
        int sum = 1; 
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
                if (i * i != n)
                {
                    sum += n / i;
                }
            }
        }
        return sum == n;
    }

    static void PrintFibonacci(int n)
    {
        if (n <= 0) return;

        long f0 = 0, f1 = 1;
        Console.Write($"Dãy Fibonacci {n} số: ");

        int count = 0;
        while (count < n)
        {
            if (count == 0)
            {
                Console.Write(f0);
            }
            else if (count == 1)
            {
                Console.Write($", {f1}");
            }
            else
            {
                long fn = f0 + f1;
                Console.Write($", {fn}");
                f0 = f1;
                f1 = fn;
            }
            count++;
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số nguyên dương N: ");
        int n = int.Parse(Console.ReadLine()!);

        if (IsPerfectNumber(n))
        {
            Console.Write($"{n} là Số hoàn hảo! ");
        }
        else
        {
            Console.Write($"{n} KHÔNG là Số hoàn hảo! ");
        }

        if (IsPrime(n))
        {
            Console.Write($"{n} là Số nguyên tố. ");
        }
        else
        {
            Console.Write($"{n} KHÔNG là Số nguyên tố. ");
        }

        PrintFibonacci(n);

        Console.ReadKey();
    }
}