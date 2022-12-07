// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear(); 

void FindEqual(int n)
{
    if(n/10000-(n/10)%10==0 && (n/1000)%10-n%10==0) 
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
// Анализируем данные
int result = FindEqual(n);


