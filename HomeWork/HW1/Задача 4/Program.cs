Console.Clear();

Console.WriteLine("Введите число a ");
double numberA = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число b ");
double numberB = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число c ");
double numberC = double.Parse(Console.ReadLine());

double max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("max= ");
Console.WriteLine(max);

