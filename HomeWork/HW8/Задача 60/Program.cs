// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintArray(int[,,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        { 
            for(int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write(arr[i,j,k]+" " + "(" + i + ", " + j + ", " + k + ")"); 
            }
            Console.WriteLine();
        }
    }
}

int[,,] FillArray(int rows, int columns, int third, int begin, int end)
{
    int[,,] array = new int[rows, columns, third];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < third; k++)
            {
                array[i,j,k] = new Random().Next(begin, end+1);
            }
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
int x = EnterData("Введите X:");
int y = EnterData("Введите Y:");
int z = EnterData("Введите Z:");
//Заполнение
int[,,] arrayV = FillArray(x, y, z, 10, 100);
// Вывод массива
PrintArray(arrayV);