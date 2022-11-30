Console.Clear();
Console.WriteLine("Напишите число от 1 до 7");
int number = int.Parse(Console.ReadLine());

string[] days = new string[8];
days[0] = "Нет такого дня";

days[1] = "Понедельник";
days[2] = "Вторник";
days[3] = "Среда";
days[4] = "Четверг";
days[5] = "Пятница";
days[6] = "Суббота";
days[7] = "Воскресенье";

Console.WriteLine($"День {number}: {days[number]}");