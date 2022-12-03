int Max(int arg1, arg2, arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; 
}
int[] array = {11, 21, 31, 41, 51, 61, 71, 81, 91};
array [0]=12;
Console.WriteLine(array[4]);


