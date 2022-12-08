// В тесте нужно все пробелы заменить черточками, маленьке "к" на большие, большие "С" на меленькие 
string text = " 'Always forgive your enemies;"
            + "nothing annoys them so much.'" 
            + "Oscar Wilde ";

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for(int i = 0; i<length; i++);
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();

string newText = Replace(newtext, 'k', 'K');
Console.WriteLine(newText);
Console.WriteLine();

string newText = Replace(newtext, 'C', 'c');
Console.WriteLine(newText);
Console.WriteLine();