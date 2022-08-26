/*
    Задача 48: Задайте двумерный массив размера m на n,
    каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
    Выведите полученный массив на экран.
    m = 3, n = 4.
    0 1 2 3
    1 2 3 4
    2 3 4 5
*/

Console.Clear();

Console.Write("Введите число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] twoDimensionalArray = CreateTwoDimensionalArray(rows, columns);
PrintTwoDimensionalArray(twoDimensionalArray);

int[,] CreateTwoDimensionalArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = i + j;
        }
    }
    return array;
}

void PrintTwoDimensionalArray(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;

    Console.ForegroundColor = ConsoleColor.Green;
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
    Console.ResetColor();
}
