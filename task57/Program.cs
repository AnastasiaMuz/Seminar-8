// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
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

int[] array = new int[10];
for(int i = 0; i < matrix.GetLength(0); i++) //0- обозначает строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - обозначает столбцы
        {
           array[matrix[i,j]] = array[matrix[i,j]] + 1;
        }
        
    }
Console.WriteLine(string.Join(", ", array));
for(int i = 0; i<array.Length; i++)
{
    Console.WriteLine($"Количество повторений числа {i} в массиве равно {array[i]}");
}