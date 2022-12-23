// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountElements(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            result = result + 1;
        }
    }
    return result;
}

int[] EnterData(string text)
{
    Console.WriteLine(text);
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);;
    return arr;
}

// Ввести массив
int[] array = EnterData("Введите массив: ");
// Посчитать положительные числа
int number = CountElements(array);
// Вывод данных
Console.WriteLine("Положительных чисел в заданном массиве: " + number);
