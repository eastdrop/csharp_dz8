/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] GenerateMatrix(int m, int n)
{
    int maxRow;
    int maxCol;
    int minRow;
    int minCol;
    int selectRow;
    int selectCol;

    int[,] array = new int[m, n];
    maxRow = array.GetLength(0) - 1;
    maxCol = array.GetLength(1) - 1;
    selectRow = minRow = 0;
    selectCol = minCol = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[selectRow, selectCol] = i + 1;
        if (selectRow == minRow && selectCol < maxCol)
        {
            selectCol++;
        }
        else if (selectRow == minRow && selectCol == maxCol)
        {
            selectRow++;
        }
        else if (selectRow < maxRow && selectCol == maxCol)
        {
            selectRow++;
        }
        else if (selectRow == maxRow && selectCol == maxCol)
        {
            minRow++;
            selectCol--;
        }
        else if (selectRow == maxRow && selectCol > minCol)
        {
            selectCol--;
        }
        else if (selectRow == maxRow && selectCol == minCol)
        {
            maxCol--;
            selectRow--;
        }
        else if (selectRow < maxRow && selectCol == minCol)
        {
            selectRow--;
            maxRow--;
        }
        else if (selectRow == minRow && selectCol == minCol)
        {
            selectCol++;
            minCol++;

        }
    }
    int maxLenghthNumb = array.Length.ToString().Length;
    string result = "";
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            result = array[row, col].ToString();
            if (result.Length != maxLenghthNumb)
            {
                int xLeng = maxLenghthNumb - result.Length;
                result = $"{new string('0', xLeng)}{result}";
            }
            Console.Write(result + " ");
        }
        Console.WriteLine();
    }
    return array;
}



int[,] spiralMatrix = GenerateMatrix(4, 4);
