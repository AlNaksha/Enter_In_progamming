/*// Задача 46:
    Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
    m = 3, n = 4.
    1 4 8 19
    5 -2 33 -2
    77 3 8 1

///
int[,] FillMatrix(int m, int n){

    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите число строк = ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число столбцов = ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(row, column);
PrintMatrix(matrix);


//*/

/*// Задача 48:
    Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = i+j. Выведите полученный массив на экран.
    m = 3, n = 4.
    0 1 2 3
    1 2 3 4
    2 3 4 5
///
int[,] FillMatrixNew(int n, int m)
{
    int[,] a = new int[n, m];
        for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = i+j;
        }
    }
    return a;
}


void PrintMatrix(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j]}\t");
        }
        Console.WriteLine();
    }
}



Console.WriteLine("введите n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите m");
int m = Convert.ToInt32(Console.ReadLine());

int[,] a = FillMatrixNew(n, m);
PrintMatrix(a);


//*/

/*// Задача 49:
    Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
    Например, изначально массив
    выглядел вот так:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Новый массив будет выглядеть 
    вот так:
    1    4   49  2
    5    9   2   3
    64   4   4   4
///
int[,] FillMatrix(int n, int m)
{
    int[,] a = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = rnd.Next(0, 10);
        }
    }
    return a;
}


void PrintMatrix(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j]}\t");
        }
        Console.WriteLine();
    }
}



Console.WriteLine("введите n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите m");
int m = Convert.ToInt32(Console.ReadLine());

int[,] a = FillMatrix(n, m);
PrintMatrix(a);
for (int i = 0; i < a.GetLength(0); i+=2)
    {
        for (int j = 0; j < a.GetLength(1); j+=2)
        {
            a[i,j]=a[i,j]*a[i,j];
        }
            }

Console.WriteLine("Новая матрица:");
PrintMatrix(a);
//*/

/*// Задача 51:
    Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Сумма элементов главной диагонали: 1+9+2 = 12
///

int[,] FillMatrix(int m){
    int[,] matrix = new int[m, m];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int MainDiag(int[,] matrix){
    int sum=0;
    for (int i = 0; i < matrix.GetLength(0); i++){
        if (i >= (matrix.GetLength(0)-1) && i >= (matrix.GetLength(1)-1) )
            return sum;
        sum+=matrix[i,i];
    }
    return sum;
}

System.Console.Write("Введите число строк и столбцов = ");
int row = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(row);
PrintMatrix(matrix);
System.Console.WriteLine($"Сумма главной диагоняли = {MainDiag(matrix)}");
//*/

/*// Задача 53:
    Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/// 

int[,] FillMatrix(int m, int s=0, int e=10){
    int[,] matrix = new int[m, m];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = rnd.Next(s, e);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, string str="\n"){
    System.Console.WriteLine(str);
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void swapRow(int[,] matrix){
    int temp;
    for (int i=0; i < matrix.GetLength(1); i++){
        temp = matrix[0,i];
        matrix[0,i]= matrix[matrix.GetLength(0)-1,i];
        matrix[matrix.GetLength(0)-1,i]=temp;
    }

}

System.Console.Write("Введите число строк и столбцов = ");
int row = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(row, 2, 15);
PrintMatrix(matrix,"Исходная матрица");
swapRow(matrix);
PrintMatrix(matrix);

//*/ 

/*// 

*/// 

/// 

/// 
/// 
/// 
/// 
///