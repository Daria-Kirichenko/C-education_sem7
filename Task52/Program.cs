// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// ​Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetNewMatrix(int rows, int columns, int leftBorder = 0, int righrBorder = 10)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, righrBorder);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов:");

int[] SummaryOfColumns(int[,] matrix)
{
    int[] sum = new int [n];
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            sum[j] = matrix[i, j]++;
            j++;
        }
    }
    return sum;
}

int[,] myMatrix = GetNewMatrix(m, n);
PrintMatrix(myMatrix);
int[] summary = SummaryOfColumns(myMatrix);
Console.WriteLine($"{string.Join(", ", summary)}");

