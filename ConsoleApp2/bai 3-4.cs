using System;
using System.Globalization;

class Program
{

    static void RunCalculator()
    {
        Console.WriteLine("\n BÀI TẬP 1: MÁY TÍNH CƠ BẢN ");
        Console.Write("Nhập số thứ nhất (a): ");
        double a = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Nhập số thứ hai (b): ");
        double b = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Nhập toán tử (+, -, *, /, %): ");
        char op = Console.ReadLine()![0];

        string result = (op, b) switch
        {
            ('+', _) => (a + b).ToString("F2", CultureInfo.InvariantCulture),
            ('-', _) => (a - b).ToString("F2", CultureInfo.InvariantCulture),
            ('*', _) => (a * b).ToString("F2", CultureInfo.InvariantCulture),
            ('/' or '%', 0) => "Lỗi: Không thể chia cho 0!",
            ('/', _) => (a / b).ToString("F2", CultureInfo.InvariantCulture),
            ('%', _) => (a % b).ToString("F2", CultureInfo.InvariantCulture),
            _ => "Lỗi: Phép toán không hợp lệ!"
        };

        Console.WriteLine($"Kết quả: {result}");
    }

    static void RunQuadraticEquation()
    {
        Console.WriteLine("\n BÀI TẬP 2: GIẢI PHƯƠNG TRÌNH BẬC HAI (ax^2 + bx + c = 0) ===");
        Console.Write("Nhập hệ số a: ");
        double a = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Nhập hệ số b: ");
        double b = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Nhập hệ số c: ");
        double c = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine(c == 0 ? "Phương trình có vô số nghiệm." : "Vô nghiệm.");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Phương trình bậc nhất có nghiệm: x = {x.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1 = {x1.ToString("F2", CultureInfo.InvariantCulture)}, x2 = {x2.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Nghiệm kép x = {x.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Vô nghiệm.");
            }
        }
    }

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
                if (i * i != n) sum += n / i;
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
            if (count == 0) Console.Write(f0);
            else if (count == 1) Console.Write($", {f1}");
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

    static void RunPrimeAndFibonacci()
    {
        Console.WriteLine("\n=== BÀI TẬP 3: KIỂM TRA SỐ & DÃY FIBONACCI ===");
        Console.Write("Nhập số nguyên dương N: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write(IsPerfectNumber(n) ? $"{n} là Số hoàn hảo! " : $"{n} KHÔNG là Số hoàn hảo! ");
        Console.Write(IsPrime(n) ? $"{n} là Số nguyên tố. " : $"{n} KHÔNG là Số nguyên tố. ");
        PrintFibonacci(n);
    }


    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string choice;

        do
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("          CHƯƠNG TRÌNH CONSOLE MENU     ");
            Console.WriteLine("\n");
            Console.WriteLine("1. Chạy Bài tập 1 (Calculator)");
            Console.WriteLine("2. Chạy Bài tập 2 (Phương trình bậc 2)");
            Console.WriteLine("3. Chạy Bài tập 3 (Số nguyên tố & Fibonacci)");
            Console.WriteLine("0. Thoát chương trình");
            Console.WriteLine("\n");
            Console.Write("Vui lòng chọn chức năng (0-3): ");

            choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    RunCalculator();
                    break;
                case "2":
                    RunQuadraticEquation();
                    break;
                case "3":
                    RunPrimeAndFibonacci();
                    break;
                case "0":
                    Console.WriteLine("\nĐang tắt chương trình");
                    break;
                default:
                    Console.WriteLine("\nLựa chọn không hợp lệ! Vui lòng chọn lại.");
                    break;
            }

            if (choice != "0")
            {
                Console.WriteLine("\n");
                Console.Write("Nhấn phím bất kỳ để quay lại Menu chính");
                Console.ReadKey();
            }

        } while (choice != "0");
    }
}