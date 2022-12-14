// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int CountPlus (int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] %2==0)
        {
            result = result + 1;
        }
    }
    return result;
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
int[] array = CreateMassive(10,100,999);
Console.WriteLine(String.Join(", ", array));
//Ищем число четных
int count = CountPlus (array);
Console.WriteLine($"Количество четных чисел в массиве: {count}");