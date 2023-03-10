int[,] GetMatrix(int rowsCount, int columnCount, int leftRange=0, int rightRange=50)
{
    int[,] matr = new int [rowsCount, columnCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand. Next(leftRange, rightRange + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
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

int [,] matr = GetMatrix(4, 4, 3, 9);
PrintMatrix(matr);
Task(matr);
Console.WriteLine();
PrintMatrix(matr);



void Task(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if ((i+1)%2 == 0 && (j+1)%2 == 0)
            {
                matr[i, j] = matr[i, j]*matr[i, j];
            }

        }
    }
}

