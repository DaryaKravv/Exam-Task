Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

void number(int n)
{
    Console.Write(n + " ");
    if (n == 1)
    {
        return;
    }
    number(n - 1);
}
number(n);
