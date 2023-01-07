Console.WriteLine("Введите число");
int m = Convert.ToInt32(Console.ReadLine());


int number(int m)
{
    int sum = 0;
    if (m == 0)
    {
        return 0;
    }
    sum = number(m / 10) + m % 10;
    return sum;
}
int sum = number(m);
Console.WriteLine(sum);