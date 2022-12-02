Console.Clear();

Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine());
int i = 2;

while(i < N)
{
    if(i%2==0)
    { 
      Console.Write(i);
    }

    else 
    {
        i++;
    }
}

 Console.Write(i);
