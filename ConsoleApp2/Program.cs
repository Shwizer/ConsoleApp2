using System;
using System.Globalization;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số thứ nhất (a): ");
        double a = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Nhập số thứ hai (b): ");
        double b = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Nhập toán tử (+,-,*,/,%): ");
        char c = Console.ReadLine()![0];

        string result = (c, b) switch {

            ('+', _) => (a + b).ToString("F2", CultureInfo.InvariantCulture),
            ('-', _) => (a - b).ToString("F2", CultureInfo.InvariantCulture),
            ('/' or '%', 0) => "không thể chia cho 0",
            ('/', _) => (a / b).ToString("F2", CultureInfo.InvariantCulture),
            ('%', _) => (a % b).ToString("F2", CultureInfo.InvariantCulture),
            _ => "Lỗi: Phép toán không hợp lệ!"};
        Console.WriteLine($"{result}");
        Console.ReadKey();
    }
}
