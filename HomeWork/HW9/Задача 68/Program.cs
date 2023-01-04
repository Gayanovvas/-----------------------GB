// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction(int m, int n)
{
    if(m==0) return n+1;
    if(n==0 && m>0) return AkkermanFunction(m-1,1);
    else return AkkermanFunction(m-1,AkkermanFunction(m,n-1));
} 

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Запросим числа
int m = EnterData("Введите число m: ");
int n = EnterData("Введите число n: ");
// Поиск и вывод чисел 
Console.WriteLine(AkkermanFunction(m,n));