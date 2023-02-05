string[] M;
Console.WriteLine("Введите массив строк через пробел");
string String = Console.ReadLine();
M = String.Split(' ');
var result = new string[M .Length];
var Size = 0;
foreach (var value in M )
{
    if (value.Length <= 3)
    {
        result[Size] = value;
        Size++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, Size));
Console.ReadKey(true);