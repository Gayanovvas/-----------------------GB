// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int FindMinSum(int[,] arr)
{
    int sum = 0;
    int min = 0;
    int row = 1;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(j < arr.GetLength(1)-1)
            {
                sum = arr[i,j]+arr[i,j+1];
            }
            if(i==0) min = sum;
            if(sum < min)
            {
                min = sum;
                row = i++;
            }
        }
    }
    return row;
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
int[,] matrix = FillArray(rows, columns, -10, 10);
// Вывод массива
PrintArray(matrix);
// Посчитать сумму элементов в каждой строке и сравнить
int MinRow = FindMinSum (matrix);
Console.WriteLine("Минимальная сумма элементов в " + MinRow + " строке");