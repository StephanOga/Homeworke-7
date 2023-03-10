// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix(int rows, int columns)
{
    return new int[rows, columns];
}

int GetValueFromUser(string text)
{
    Console.WriteLine(text);
    int value = int.Parse(Console.ReadLine());
    return value;
}

void RandomMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

string ArithmeticMeanColumns(int[,] matrix)
{
    string arithmeticMean = "";
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double arithmMean = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arithmMean += matrix[i, j];
        }

        arithmMean /= matrix.GetLength(0);
        arithmMean = Math.Round(arithmMean, 1);
        arithmeticMean += arithmMean + " ";
    }
    return arithmeticMean;
}

int myRows = GetValueFromUser("Сколько будет строк в вашей матрице: ");
int myColumns = GetValueFromUser(" Сколько будет столбцов в вашей матрице: ");

int[,] mymatrix = CreateMatrix(myRows, myColumns);
RandomMatrix(mymatrix);
Console.WriteLine();

PrintMatrix(mymatrix);
Console.WriteLine();

Console.WriteLine("Cреднее арифметическое по каждому столбцу");
string s = ArithmeticMeanColumns(mymatrix);
Console.WriteLine(s);