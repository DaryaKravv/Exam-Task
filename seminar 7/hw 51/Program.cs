
Random random  = new Random();
int[,] matr = new int[random.Next(1, 10), random.Next(1, 10)];

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j ++)
    {
        matr[i, j] = random.Next(1, 10);
        Console.Write(matr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine(matr.GetLength(0));
for (int j = 0; j < matr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum += matr[i, j];
    }
    Console.Write($"{ sum / matr.GetLength(0)} ");
}
Console.ReadLine();
