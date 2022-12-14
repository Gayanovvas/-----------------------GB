// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Amount(int a)
{
    int sum = 0;
    for( ; a > 0; a/=10)
    {
        sum = sum + a%10;
    }
    return sum; 
}

int a = EnterData("Введите число: ");
int result = Amount(a);
Console.WriteLine(result);
