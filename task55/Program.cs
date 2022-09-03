// Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //0- обозначает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - обозначает столбцы
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;

}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++) //0- обозначает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - обозначает столбцы
        {
            Console.Write(matrix [i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write ("Введите m и n через Enter: "); //число строк
int m = Convert.ToInt32(Console.ReadLine());

int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();

int[,] reversMatrix = new int[matrix.GetLength(1),matrix.GetLength(0)];
for(int i = 0; i < matrix.GetLength(1); i++) //0- обозначает строки
    {
        for (int j = 0; j < matrix.GetLength(0); j++) // 1 - обозначает столбцы
        {
            reversMatrix[i,j] = matrix[j,i];
        }
       
    }
PrintMatrix(reversMatrix);
