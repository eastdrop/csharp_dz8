/*Задача 60. ...Сформируйте трёхмерный массив двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1)*/

int[,,] GenerateMatrix(int str, int column, int depth)
{
    int[,,] matrix = new int[str, column, depth];
    Random rand = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                matrix[i, j, k] = rand.Next(0, 10);
            }

        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write(matr[i, j, k] + $"({j},{k},{i})" + "\t");
            }
            Console.WriteLine();
        }
        
    }
}

int[,,] newMatrix = GenerateMatrix(2, 2, 2);
PrintMatrix(newMatrix);