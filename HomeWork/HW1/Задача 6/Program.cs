Console.Clear();

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());

if (number%2==0) 
{
    Console.Write("Четное");
}

else
{
    Console.Write("Нечетное");
}

