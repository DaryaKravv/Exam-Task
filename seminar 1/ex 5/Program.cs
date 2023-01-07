Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)
{
    Console.WriteLine(number % 10);
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}