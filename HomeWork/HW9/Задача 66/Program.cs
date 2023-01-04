// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfNumbers(int start, int finish)
{
    int sum = finish;
    if (start==finish) return sum;
    else
    {
            sum = start + SumOfNumbers(start+1, finish);
    }
    return sum;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Запросим координаты чисел
int n = EnterData("Введите число N: ");
int m = EnterData("Введите число M: ");
//
int sum = SumOfNumbers(n,m);
Console.WriteLine(sum);