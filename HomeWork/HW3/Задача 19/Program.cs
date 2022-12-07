// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear(); 

void FindEqual(int n)
{
    int x1 = n/10000;
    int x2 = (n/1000)%10;
    int x4 = (n/10)%10;
    int x5 = n%10;
    if (x1==x5 && x2==x4) 
    {
        Console.WriteLine("Да");
    }
    else 
    {
        Console.WriteLine("Нет");
    }
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Запросим координаты чисел
int n = EnterData("Введите пятизначное число: ");
FindEqual(n);


