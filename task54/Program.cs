/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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

void SortFromMaxtoMin(int[,] matrix)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int maxPos = j;
            for (int k = j + 1; k < matrix.GetLength(0); k++)
            {
                if (matrix[i, k] > matrix[i, maxPos]) { maxPos = k; }
            }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, maxPos];
            matrix[i, maxPos] = temp;
        }         
    }
    
}

int[,] newMatrix = GenerateMatrix(5, 5);
PrintMatrix(newMatrix);
Console.WriteLine();
SortFromMaxtoMin(newMatrix);
PrintMatrix(newMatrix);
