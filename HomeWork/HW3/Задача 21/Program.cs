// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDist(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double D = Math.Pow(((xB - xA) + (yB-yA) + (zB-zA)), 3);
    return D;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Запросим координаты чисел
double xA = EnterData("Введите кординаты X для точки A: ");
double yA = EnterData("Введите кординаты Y для точки A: ");
double zA = EnterData("Введите кординаты Z для точки A: ");
double xB = EnterData("Введите кординаты X для точки B: ");
double yB = EnterData("Введите кординаты Y для точки B: ");
double zB = EnterData("Введите кординаты Z для точки B: ");
// Анализируем данные
double number = FindDist(xA, yA, zA, xB, yB, zB);
// Вывод информации1
Console.WriteLine("Росстояние составляет: " + number);
