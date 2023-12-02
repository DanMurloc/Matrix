int[,] matrix = {
    {2, 1, 9, 3, 0},
    {2, 1, 9, 3, 0},
    { 1, 2, 3, 4, 5 },
    { 1, 2, 3, 4, 5 },
    {5,8,2,8,1},
    {5,8,2,8,1},    
    { 1, 2, 3, 4, 5 },
    {5,6,7,8,9 },
    {5,6,7,8,9 },
};

int chek = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int temp = matrix[i,0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        if (temp> matrix[i, j])
        {
            break;
        }
        else
        {
            temp = matrix[i,j];
            if (j == matrix.GetLength(1) - 1)
            {
                chek++;
            }
        }

    }
}
Console.WriteLine(chek);