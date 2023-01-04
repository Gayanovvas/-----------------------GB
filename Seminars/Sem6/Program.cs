// Написать программу, которая перевернет одномерный массив

void ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
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
int[] array = CreateMassive(7, 1, 20);
Console.WriteLine(String.Join(" ", array));
// Переворачиваем
ReverseArray(array);
Console.WriteLine(String.Join(" ", array));