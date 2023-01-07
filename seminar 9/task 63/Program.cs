// рекурсия

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

void number(int num)
{
    if (num == 0)
    {
        return;
    }
    number(num - 1);
    Console.Write(num +" ");
}
number(N);