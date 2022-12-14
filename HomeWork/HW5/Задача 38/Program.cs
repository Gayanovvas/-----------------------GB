// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int FoundMin (int[] array)
{ 
    int min = array[0];
    for(int i = 0; i < array.Length; i++) 
    {
        if(array[i]<min) min = array[i];
    }
    return min;
}

int FoundMax (int[] array)
{ 
    int max = array[0];
    for(int i = 0; i < array.Length; i++) 
    {
        if(array[i]>max) max = array[i];
    }
    return max;
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

//Создаем массив
int[] array = CreateMassive(10,-100,100);
Console.WriteLine(String.Join(", ", array));
// Ищем минимальное и максимальное
int min = FoundMin (array);
int max = FoundMax (array);
Console.WriteLine("Минимальное число: " + min);
Console.WriteLine("МАксимальное число: " + max);
// Ищем разницу
int diff = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");