int[,] pic = new int[,]
{
    // Тут должен быть массив
}

void PrintImage(int[,] image)
{
    for(int rows = 0; rows < image.GetLength(0); rows++)
    {
        for(int colums = 0; colums < image.GetLength(1); colums++)
        {
            // Console.Write($"{image[rows, colums]} ");
            if(image[rows, colums]==0) Console.Write(" ");
            else Console.Write("+");
        }
    Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}

PrintImage(pic);
FillImage(13,13);
PrintImage(pic);