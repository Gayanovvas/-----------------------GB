// Сгенерировать число 
int n = new Random().Next(10, 100);
Console.WriteLine(n);
// Разделить число на 2 перемененные 
int numberA = n%10;
int numberB = n/10;
int max = numberA;
// Сравнить перемененные
if(numberB > max) max = numberB;
// Вывести большее число через max
Console.WriteLine("В числе " + n + " цифра " + max + " наибольшая");