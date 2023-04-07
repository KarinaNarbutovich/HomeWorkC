// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

void InputMatrix (int[,] matrix)
{
    int temp=1;
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            if (i==0)
            {
            matrix[i,j]=temp; temp++;   
            }
            if (i>0 && j==matrix.GetLength(1)-1)
            {
                matrix[i,matrix.GetLength(1)-1]=temp; temp++; 
            }
        }
        for (int j=matrix.GetLength(1)-1; j>=0; j--)
        {
           if (i==matrix.GetLength(0)-1 && j<matrix.GetLength(1)-1) 
           {
            matrix[i,j]=temp; temp++;
           }
        }   
    }
        for (int k=matrix.GetLength(0)-2; k>0; k--)
        {
            matrix[k,0]=temp; temp++;
        }
        for (int l=1; l<matrix.GetLength(1)-1; l++)
        {
            matrix[1,l]=temp; temp++;
        }
        for (int m=2; m>0; m--)
        {
            matrix[2,m]=temp; temp++;
        }
}

void PrintMatrix (int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.Write("\n");
    }
}

Console.Clear();
int n=4; 
int[,] array=new int[n,n];
InputMatrix(array);
PrintMatrix(array);
Console.Write("\n");