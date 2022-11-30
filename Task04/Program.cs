Console.Clear();
Console.Write("Напишите число ");
int N = int.Parse(Console.ReadLine());
int index = -N;
while (index < N+1)
{
    Console.WriteLine(index);
    index++;
}