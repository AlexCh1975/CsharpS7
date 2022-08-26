/*
    Задача 51: Задайте двумерный массив. Найдите сумму
    элементов, находящихся на главной диагонали (с индексами
    (0,0); (1;1) и т.д.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Сумма элементов главной диагонали: 1+9+2 = 12
*/

Console.Clear();

Console.Write("Введите число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] twoDimensionalArray = CreateTwoDimensionalArray(rows, columns);
int summa = GetSumElementsDiagonalArray(twoDimensionalArray);
PrintTwoDimensionalArray(twoDimensionalArray, summa);

int[,] CreateTwoDimensionalArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(0, 100);
        }
    }
    return array;
}

int GetSumElementsDiagonalArray(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;
    int summa = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j) summa += array[i,j];
        }
    }
    return summa;
}

void PrintTwoDimensionalArray(int[,] array, int summa)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("[");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"\t{array[i,j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine("]");
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов главной диагонали = {summa}");
    Console.ResetColor();
}