int[,] GetMatrix(int rowsCount, int columnCount, int leftRange=0, int rightRange=50) //параметры метода который возвращает массив и что получает
{
    int[,] matr = new int [rowsCount, columnCount]; // создаем массив
    Random rand = new Random(); // создание рандомизатора, можно убрать

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }
    return matr;
}

int GetNumber(string message) //считаем с консоли метод!
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
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

int rows = GetNumber("Введите число строк"); 
int columns = GetNumber("Введите число стобцов");

int[,] matrix = GetMatrix(rows, columns);

PrintMatrix(matrix); // по каждому обьекту проходим  
