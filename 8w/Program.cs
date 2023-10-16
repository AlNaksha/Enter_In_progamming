int getInt(string str="")                               // Получение целого числа с консоли с текстом запроса
    {
        Console.Write(str);
        return Convert.ToInt32(Console.ReadLine());
    }

int[,] FillMatrix(int m=1, int n=1, int s=0, int e=5)      // Инициализация массива с заполнением случайными значениями ( по умолч [0..9])
    {
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = rnd.Next(s,e);
        }
    }
    return matrix;
    }

void PrintMatrix(int[,] matrix, string str="")          // Вывод матрицы в консоль с описанием
    {
        System.Console.WriteLine(str);
        for (int i = 0; i < matrix.GetLength(0); i++){
            for (int j = 0; j < matrix.GetLength(1); j++){
                System.Console.Write($"{matrix[i, j]} ");
            }
            System.Console.WriteLine();
        }
    }
///

/*// Задача 55: 
    Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
    ///

    int[,] transpMatrix(int[,] baseMatrix){
        int[,] newMatrix = new int[baseMatrix.GetLength(1),baseMatrix.GetLength(0)];

        for (int i = 0; i < baseMatrix.GetLength(0); i++){
            for (int j = 0; j < baseMatrix.GetLength(1); j++){
                newMatrix[j,i] = baseMatrix[i,j];
            }
        }

        return newMatrix;
    }

    void transpMatrix2(int[,] baseMatrix){
        int[,] newMatrix = new int[baseMatrix.GetLength(1),baseMatrix.GetLength(0)];
        int[,] Matrix = baseMatrix;
        for (int i = 0; i < baseMatrix.GetLength(0); i++){
            for (int j = 0; j < baseMatrix.GetLength(1); j++){
                newMatrix[j,i] = baseMatrix[i,j];
            }
        }

        baseMatrix = newMatrix;
    }

    void viewTranspMatrix(int[,] baseMatrix){
        int[,] newMatrix = new int[baseMatrix.GetLength(1),baseMatrix.GetLength(0)];

        for (int i = 0; i < baseMatrix.GetLength(1); i++){
            for (int j = 0; j < baseMatrix.GetLength(0); j++){
                System.Console.WriteLine($"baseMatrix[i,j] ");
            }
            System.Console.WriteLine();
        }
    }


    int[,] matrix = FillMatrix(getInt("Число строк = "), getInt("Число столбцов = "));
    PrintMatrix(matrix, "Исходная матрица:");
    
    transpMatrix2(matrix);
    viewTranspMatrix(matrix);
    PrintMatrix(transpMatrix(matrix), "Транспонированная матрица:");
    //*/


/*// Задача 57:
    Составить частотный словарь элементов двумерного массива. 
    Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
    1, 2, 3 
    4, 6, 1 
    2, 1, 6
    1 встречается 3 раза 
    2 встречается 2 раз 
    3 встречается 1 раз 
    4 встречается 1 раз 
    6 встречается 2 раза
    //*/
    /*// Метод через трехстолбцовую матрицу
        void PrintMatrixSame(int[,] counter){     // Вывод матрицы в консоль с описанием
            for (int i = 0; i < counter[0,2]-1; i++){
                System.Console.WriteLine($"{counter[i, 0]} встречается {counter[i, 1]} раз");
            }
        }
        void viewCountSame(int[,] matrix){
            int[,] counter = new int[matrix.Length,3];
            counter[0,0] = matrix[0,0];
            counter[0,1] = 1;
            counter[0,2] = 1;

            for (int i = 0; i < matrix.GetLength(0); i++){
                for (int j = 0; j < matrix.GetLength(1); j++){
                    int z = 0;
                    int l = i*matrix.GetLength(1) + j;
                    for (; z < l; z++){
                        if (counter[z,0]==matrix[i,j]){
                            counter[z,1]++;
                            break;
                        }
                        //System.Console.WriteLine($"M:{i} {j} {matrix[i, j]}\tCZ:{z} {counter[z,0]} c:{counter[z,1]}");
                    }
                    if (counter[z,0] == 0&&z<matrix.Length){
                        counter[z,0] = matrix[i,j];
                        counter[z,1] = 1;
                        counter[0,2]++;
                        }
                    System.Console.WriteLine($"M: {i} {j} | {matrix[i, j]} || {z} | {counter[z,0]} {counter[z,1]} {counter[0,2]}");
                }
            }
            System.Console.WriteLine("пройден цикл");
            PrintMatrixSame(counter);
        }
        //*/
    /// Метод через одномерный массив
        void viewCountSame(int[,] matrix){
            int[] counter = new int[matrix.Length]; //массив 
            int columnLength = matrix.GetLength(1);
            System.Console.WriteLine($"\n{matrix.Length} {matrix.GetLength(1)}");
            for(int i=0; i<counter.Length; i++){
                if (counter[i]>=0){
                    counter[i]++;
                    for(int j=i+1; j<counter.Length; j++){
                        if ( matrix[i/columnLength, i%columnLength] == matrix[j/columnLength, j%columnLength]){
                            counter[i]++;
                            counter[j]=-1;
                        }
                        // System.Console.WriteLine($"\ti:{i} j:{j}  r{i/columnLength} c{i%columnLength} {matrix[i/columnLength, i%columnLength]} | {matrix[j/columnLength, j%columnLength]} || {counter[i]}");
                    }
                }
            }
            
            for (int i = 0; i < counter.Length; i++){
                if (counter[i]!=-1)
                    System.Console.WriteLine($"{matrix[i/columnLength, i%columnLength]} встречается {counter[i]} раз");
            }
        }
    ///

    ///

        ///

    int[,] matrix = FillMatrix(getInt("Число строк = "), getInt("Число столбцов = "));
    PrintMatrix(matrix, "Исходная матрица:");
    viewCountSame(matrix);
        //*/


/*//

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


    int[] CountElements(int[,] a)
        {
            int[] b = new int[10];
            for (int k = 0; k < 10; k++)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] == k)
                        {
                            b[k]++;
                        }
                    }
                }
            }
            return b;
        }


    Console.WriteLine("введите n");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите m");
    int m = Convert.ToInt32(Console.ReadLine());

    int[,] a = FillMatrix(n, m);
    PrintMatrix(a);

    int[] b = CountElements(a);

    for (int k = 0; k < 10; k++)
    {
        Console.WriteLine("число " + k + " встречается " + b[k] + " раз");
    }
    //*/

/*//

    ///
    int[] CntNums(int[,] matrix)
        {
            int[] result = new int[matrix.Length];
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                {
                    result[matrix[i,j]]++;
                }
            }
            return result;
        }

    //*/
/*
int SumOfRow(int[,] matrix, int row){
    int sum = 0;
    for (int i=0;i<matrix.GetLength(1); i++){
        sum += matrix[row,i];
        // System.Console.WriteLine($"M:{i}\tCZ:{sum} {matrix[row,i]}");
    }
    return sum;
    }

    int[] MinimumSumRow(int[,] matrix){
      int[] minSum = new int[2];
      minSum[1] = int.MaxValue; 
      int sum;
      for (int i=0; i<matrix.GetLength(0);i++){
        sum = SumOfRow(matrix,i);
        // System.Console.WriteLine($"M:{i}\tCZ:{sum} {minSum[0]} c:{minSum[1]}");

        if (minSum[1]>sum){
          minSum[0]=i;
          minSum[1]=sum;
        } 
      }
      return minSum;
    }
   

    int[,] matrix = FillMatrix(getInt("Число строк = "), getInt("Число столбцов = "));
    PrintMatrix(matrix, "Исходная матрица:");
    int[] minSumRow = MinimumSumRow(matrix);

    Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");
*/