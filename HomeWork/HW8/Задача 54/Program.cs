// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void SortArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for(int c = 0; c < array.GetLength(1); c++)
        {
            for(int j = 0; j < array.GetLength(1)-1; j++)
            {
                int temp = array[i,j];
                if(array[i,j]<array[i,j+1])
                {
                    array[i,j+1] = temp;
                    array[i,j] = array[i,j+1];
                    temp = array[i,j];
                }
                else j++;
            }
            Console.Write(array[i,c]+" "); 
        }
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
int[,] matrix = FillArray(rows, columns, -10, 10);
// Вывод массива
PrintArray(matrix);
// Сортировка
SortArray(matrix);
