// Вид 1
void Method1()
{
    Console.WriteLine("Автор: ...");
}
// Вызов
Method1();

// Тип 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Вызов
Method2("Текст сообщения");
// Вариант
void Method2_1(string msg, int count)
{
    int i = 0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Вызов
Method2_1(msg: "Текст", count: 4);

// Тип 3
int Method3()
{
    return DateTime.Mow.Year;
}
// Вызов
int year =  Method3();
Console.WriteLine(year);

// Тип 3
string Method4(int count, string c)
{
    int i = 0;
    string result = ""; // (Лучше String.Empty)
    
    while(i<count)
    {
        result = result + c;
        i++;
    }
    return result;
}
// Вызов
string res = Method4(10, "Bla-Bla-Bla");
Console.WriteLine(res); 

// Новый цикл for (на примере 4 метода)
string Method4(int count, string c)
{;
    string result = ""; // (Лучше String.Empty)
    for(int i = 0; i<count; i++) // инициализация счетчика; проверка условия; инкримент
    {
        result = result + c;
    }
    return result;
}
// Вызов
string res = Method4(10, "Bla-Bla-Bla");
Console.WriteLine(res); 

// Цикл в цикле (здесь: вывод таблицы умножения на экран)

for(int i=1; i<=10; i++)
{
    for(int j=2; j<=10; j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}"); 
    }
    Console.WriteLine(); 
}