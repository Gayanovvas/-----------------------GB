// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cb(int n)
{
    n = n*n*n;
    Console.Write(n + ",");
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int N = EnterData("Введите число: ");
int i = 1;
while(i<=N)
{
    Cb(i);
    i++;
}
