double[,] GetMatrix(int rowsCount, int columnCount, int leftRange=0, int rightRange=50)
{
    double[,] matr = new double [rowsCount, columnCount];
   Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.NextDouble() * 100;
        }
    }
    return matr;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int rows = GetNumber("Введите число строк");
int columns = GetNumber("Введите число стобцов");

double[,] matrix = GetMatrix(rows, columns);

PrintArray(matrix);
