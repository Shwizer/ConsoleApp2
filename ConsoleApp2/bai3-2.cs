using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

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
                if (c == 0)
                {
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                }
                else
                {
                    Console.WriteLine("Vô nghiệm.");
                }
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

        Console.ReadKey();
    }
}