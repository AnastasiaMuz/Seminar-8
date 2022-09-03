// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int min = matrix[0,0];
int iMin = 0;
int jMin = 0;

for(int i = 0; i < matrix.GetLength(0); i++) //0- обозначает строки
{
    for (int j = 0; j < matrix.GetLength(1); j++) // 1 - обозначает столбцы
    {
        if(matrix[i,j] < min)
        {
            min = matrix[i,j];
            iMin = i;
            jMin = j;
        }
    }
        
}

int rowOffset = 0;
int columnOffset = 0;
int[,] newMatrix = new int[m - 1, n - 1];
for(int i = 0; i < matrix.GetLength(0) - 1; i++) //0- обозначает строки
{
    if(i == iMin) rowOffset++;
    for (int j = 0; j < matrix.GetLength(1) - 1; j++) // 1 - обозначает столбцы
    {
        if (j == jMin) columnOffset++;
        newMatrix[i,j] = matrix[i + rowOffset, j + columnOffset];
    }
    columnOffset = 0;
        
}
PrintMatrix(newMatrix);