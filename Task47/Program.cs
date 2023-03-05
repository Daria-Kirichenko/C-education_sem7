// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int m = ReadNumber("Введите число строк:");
int n = ReadNumber("Введите число столбцов:");
double[,] GetRandomMatrix(double rows, double columns)
{
    double[,] matrix = new double[m, n];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.NextDouble() * 10;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(Math.Round(matrix[i,j], 2) + " ");
        }
        Console.WriteLine();
    }
}

// int m = ReadNumber("Введите число строк:");
// int n = ReadNumber("Введите число столбцов:");

double[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);