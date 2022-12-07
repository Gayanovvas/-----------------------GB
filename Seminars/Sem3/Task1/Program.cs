// Тут будут методы

int FindQuarter(int x, int y)
{
    int result = 0;
    if(x > 0 && y > 0) result = 1;
    if(x < 0 && y > 0) result = 2;
    if(x < 0 && y < 0) result = 3;
    if(x > 0 && y < 0) result = 4;
    return result;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Запросим координаты чисел
int x = EnterData("Введите кординаты Х: ");
int y = EnterData("Введите кординаты Y: ");
// Анализируем данные
int number = FindQuarter(x, y);
// Вывод информации1
Console.WriteLine("Ваши кординаты находятся в " + number + " четверти");
