// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B (без использования Math.Pow).
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int ProductOfNumbers(int a, int b)
{
    int result = 1;
    for(int count = 1; count <= b; count++)
    {
        result = result*a;
    }
    return result; 
}

int a = EnterData("Введите число A: ");
int b = EnterData("Введите число B: ");
int prod = ProductOfNumbers(a,b);
Console.WriteLine(prod);
