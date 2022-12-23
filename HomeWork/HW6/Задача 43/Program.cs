// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Ввести данные
int b1 = EnterData("Введите b1: ");
int k1 = EnterData("Введите k1: ");
int b2 = EnterData("Введите b2: ");
int k2 = EnterData("Введите k2: ");
// Построить прямые и найти точку пересечения 
double x = (b1-b2)/(k1-k2);
double y = k1 * x + b1;
// Вывод данных
Console.WriteLine($"Прямые пересекаются в точке: ({x};{y})");
