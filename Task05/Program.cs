Console.Clear();
Console.Write("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine());

if (number < 100) Console.WriteLine("Вы ввели число меньшее трехзначного");
if (number > 999) Console.WriteLine("Вы ввели число большее трехзачного");

Console.WriteLine($"{number%10} последняя цифра числа {number}");