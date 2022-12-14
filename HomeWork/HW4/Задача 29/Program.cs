// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.2
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateMassive(int count, int begin, int end)
{
    int[] array = new int[count];
    for(int i = 0; i < count; i++) 
    {
        array[i] = new Random().Next(begin, end+1);
    }
    return array;
}

int[] line = CreateMassive(8, 0, 10);
Console.WriteLine(line);