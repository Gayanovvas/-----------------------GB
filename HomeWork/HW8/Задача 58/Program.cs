// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MatrixProduct(int[,] matrixA, int[,] matrixB)
{
    if (matrixB.GetLength(1) != matrixA.GetLength(0)) Console.WriteLine("Умножение невозможно");
    else
    { 
        int[,] matrixC = new int[matrixB.GetLength(1),matrixA.GetLength(0)];
        for (int i=0; i<matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixA.GetLength(0); j++)
            {
               matrixC[i, j] = 0;
               for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return matrixC;
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+" "); 
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rows, int columns, int begin, int end)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(begin, end+1);
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Запрос строк
int rows = EnterData("Введите количество строк:");
// Запрос столбцов
int columns = EnterData("Введите количество столбцов:");
// Создание массива и заполнение
int[,] matrix1 = FillArray(rows, columns, -10, 10);
int[,] matrix2 = FillArray(rows, columns, -10, 10);
// Вывод массива
PrintArray(matrix1);
PrintArray(matrix2);
// Уножение матриц
MatrixProduct(matrix1, matrix2);
Console.WriteLine("Произведение матриц:");
PrintArray(MatrixProduct);