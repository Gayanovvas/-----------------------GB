Console.Clear();

Console.Write("Введите число a ");
Console.Write("Введите число b ");

double numberA = double.Parse(Console.ReadLine());
double numberB = double.Parse(Console.ReadLine());

double max = numberA;

if(numberA > numberB)
    {
        numberA = max;
    }

else 
{
    numberB = max;
}

Console.Write("max= ");
Console.WriteLine(max);
