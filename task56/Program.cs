/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] GenerateMatrix(int str, int column)
{
    int[,] matrix = new int[str, column];
    Random rand = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] StringSum(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            array[i] = sum;
        }
    }
    return array;
}

void SearchOfStringWithMinSum(int[] array)
{
    int minPos = 0;
    for (int i = 1;i < array.Length; i++) 
    {
        if (array[i] < array[minPos]) minPos = i;
    }
    Console.WriteLine($"Наименьшая сумма элементов в {minPos + 1} строке");
}

int[,] newMatrix = GenerateMatrix(5, 5);
PrintMatrix(newMatrix);
Console.WriteLine();
SearchOfStringWithMinSum(StringSum(newMatrix));
