// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 9)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
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

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");

int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
Console.WriteLine();
int position1 = ReadNumber("Введите координату i:");
int position2 = ReadNumber("Введите координату j:");


int GetNumberOfPosition(int[,] matrix)
{
    int element = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(position1 == i && position2 == j)
            {
                element = matrix[i, j];
            }
            else
            {
                Console.WriteLine("Такого числа в массиве нет");
            }
        }
    }
    return element;
}

int definition = GetNumberOfPosition(myMatrix);
Console.WriteLine($"Данной позиции соответствует элемент {definition}");
