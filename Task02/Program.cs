Console.WriteLine("Напишите два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a/b == b)
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine($"Число {a}  НЕ является квадратом числа {b}");
}