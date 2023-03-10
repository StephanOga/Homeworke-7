// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// Я решила реализовать эту задачу в формате: найти самое первое заданное число, чтобы научиться использовать 
// флаг (булево значение) для выхода из циклов.

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

void FillMatrixWithRandomNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 20);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindNumberInMatrix(int[,] matrix, int number)
{
    string result = "";

    bool flag = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                result += "Позиция вашего числа: строка" + $"{i} " + "столбец" + $"{j}";
                Console.WriteLine(result);
                flag = true;
                break;
            }
        }
        if (flag) break;
    }

    if (String.IsNullOrEmpty(result))
    {
        result += " В данной  матрице нет вашего числа";
        Console.WriteLine(result);
    }
}

int myrows = GetValueFromUser("Введите  число строк для будущей матрицы: ");
int mycolumns = GetValueFromUser("Введите число столбцов для будущей матрицы: ");
int mysteriousNumber = GetValueFromUser("Какое число надо найти? ");
int[,] mymatrix = CreateMatrix(myrows, mycolumns);
FillMatrixWithRandomNumbers(mymatrix);
PrintMatrix(mymatrix);
Console.WriteLine();
FindNumberInMatrix(mymatrix, mysteriousNumber);