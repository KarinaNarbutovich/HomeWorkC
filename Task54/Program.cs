// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

void InputMatrix (int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j]=new Random().Next(1,21);
        }
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

void DescendingRows (int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1)-1; j++)
        {
            for (int k=j+1; k<matrix.GetLength(1); k++){
          if (matrix[i,j]<matrix[i,k])
        {
            int matr=matrix[i,j];
            matrix[i,j]=matrix[i,k];
            matrix[i,k]=matr;
        }
        }}
    }
}

Console.Clear();
Console.WriteLine("Введите количество строк и столбцов: ");
int[] size=Console.ReadLine()!.Split().Select(x=>int.Parse(x)).ToArray();
int[,] array=new int[size[0],size[1]];
InputMatrix(array);
PrintMatrix(array);
Console.Write("\n");
DescendingRows(array);
PrintMatrix(array);
