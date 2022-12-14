// Принять число
int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
// Написать метод для суммы
int SumOfNumbers(int a)
{
    int sum = 0;
    for(int count = 0; count <= a; count++)
    {
        sum = sum + count;
    }
    return sum; 
}
// Вывод результата

int a = GetNumber("Введите число: ");
int s = SumOfNumbers(a);
Console.WriteLine($"Сумма: {s} ");
