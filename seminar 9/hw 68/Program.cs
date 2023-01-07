Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
//int fun = Convert.ToInt32(Console.ReadLine());
fun(m,n);
void fun (int m, int n)
{
    Console.WriteLine(m,n);
}
int fun (m,n)
{
    if (m == 0)
    {
        return (n + 1);
    }
    else if (n == 0 && m > 0)
    {
        return fun(m - 1, 1);
    }
    else 
    {
        return (fun(m - 1, fun(m, n - 1)));
    }
}
// я не понимаю в чем ошибка....... :(
