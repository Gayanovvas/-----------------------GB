// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SumNumber(int[] arr, bool simbol)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]<0)
        {
             sum = sum + arr[i];
        }
        else
        {
            i++;
        }
    }
    return sum;
}

int[] CreateMassive(int count, int begin, int end)
{
    int[] array = new int[count];
    for(int i = 0; i < count; i++) 
    {
        array[i] = new Random().Next(begin, end+1);
    }
    return array;
}

// Создаем массив
int[] array = CreateMassive(10,-100,100);
Console.WriteLine(String.Join(", ", array));
// Сумма отрицательных
int sumMinus = SumNumber(array, false);
Console.WriteLine($"Сумма отрицательных чисел равна {sumMinus}");