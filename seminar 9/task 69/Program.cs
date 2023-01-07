Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());


int number(int a, int b)
{
    if (b < 1)
    {
        return 1;
    }
    b--;
    a *= number(a,b);
       return a;
}
int res = number (a, b);
Console.WriteLine(res);
