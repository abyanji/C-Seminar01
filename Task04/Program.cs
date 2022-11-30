Console.Clear();
Console.Write("Напишите число ");
int N = int.Parse(Console.ReadLine());
int index = -N;
if (N > 0)
{
    while (index < N+1)
    {
            Console.WriteLine(index);
            index++;
    }
}
else
{
    while (N < index+1)
    {
            Console.WriteLine(N);
            N++;
    }
}