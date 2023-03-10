// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrix(int rows, int columns)
{
    return new double[rows, columns];
}

int GetValueFromUser(string text)
{
    Console.WriteLine(text);
    int value = int.Parse(Console.ReadLine());
    return value;
}

void RandomMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 100) / 10.0;
        }
    }
}

void PrintMatrix(double[,] matrix)
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

int m = GetValueFromUser("Укажите количесво строк в создаваемом двумерном массиве: ");
int n = GetValueFromUser("Укажите количесво столбцов в создаваемом двумерном массиве: ");
double[,] mymatrix = CreateMatrix(m, n);
RandomMatrix(mymatrix);
Console.WriteLine("матрица  из случайных вещественных чисел готова ");
PrintMatrix(mymatrix);