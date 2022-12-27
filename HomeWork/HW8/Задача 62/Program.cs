// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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
    int number = 1;
    int i = 0;
    int j = 0;
    int FirstRow =0;
    int FirstColumn =0;
    int LastRow =0;
    int LastColumn =0;
    while(number<=rows*columns)
    {
        if(i==FirstRow && j<columns-LastColumn-1)
        {
            array[i, j] = number;
            j++;
        }
        else 
        {
            if(j==columns-LastColumn-1 && i<rows-FirstRow-1)
            {
                array[i, j] = number;
                i++;
            }
            else
            {
                if(i==rows-FirstRow-1 && j>LastColumn)
                {
                   array[i, j] = number;
                   j--;
                }
                else
                {
                    array[i, j] = number;
                    i--;
                }
            }
        }
        if((i==FirstRow+1)&&(j==FirstColumn)&&(FirstColumn!=columns-FirstColumn-1))
        {
            FirstRow++;
            FirstColumn++;
            LastRow++;
            LastColumn++;
        }
        number++;
    }
    return array;
}


// Создание массива и заполнение
int[,] matrix = FillArray(4, 4, 1, 17);
// Вывод массива
PrintArray(matrix); 