// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double ArithmeticMean(int[,] array, int rows, int columns)
{
    int count = 0;
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            count = (count + array[i,j])/3;
        }
    }
    return count;
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

int m = EnterData("Введите количество строк");
int n = EnterData("Введите количество столбцов");
int[,] matrix = FillArray(m, n, -100, 100);
PrintArray(matrix);

double x = ArithmeticMean(matrix);
Console.WriteLine(x);