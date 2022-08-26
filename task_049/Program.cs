/*
    Задача 49: Задайте двумерный массив. Найдите элементы, у
    которых оба индекса чётные, и замените эти элементы на их
    квадраты.
    Например, изначально массив
    выглядел вот так:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Новый массив будет выглядеть
    вот так:
    1 4 7 2
    5 81 2 9
    8 4 2 4
*/

Console.Clear();

Console.Write("Введите число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] twoDimensionalArray = CreateTwoDimensionalArray(rows, columns);
PrintTwoDimensionalArray(twoDimensionalArray);
int[,] newTwoDimensionalArray = ChangeTwoDimensionalArray(twoDimensionalArray);
PrintTwoDimensionalArray(newTwoDimensionalArray);

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

int[,] ChangeTwoDimensionalArray(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if ((i + 1)  % 2 == 0 && (j + 1) % 2 == 0)
            {
                array[i,j] = array[i,j] * array[i,j];
            }
            else array[i,j] = array[i,j];
        }
    }
    return array;
}

void PrintTwoDimensionalArray(int[,] array)
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
    Console.WriteLine("----------------------------");
    Console.ResetColor();
}
