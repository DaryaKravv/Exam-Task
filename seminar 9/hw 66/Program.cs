Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void number(int m, int n)
{
    if (n < m)
    {
        return;
    }
    number(m, n - 1);
    sum = sum + (n++);
}
number(m, n);
Console.Write(sum);