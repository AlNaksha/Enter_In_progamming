/*// Задача 40:
Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
///

int getInt(string str){ // Получение целого числа с консоли с текстом запроса
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int a = getInt("Введите a: ");
int b = getInt("Введите b: ");
int c = getInt("Введите c: ");

if((a+b>c)&&(a+c>b)&&(c+b>a)){
    Console.Write("Треуг сущ.");
}
else{
    Console.Write("Треуг не сущ.");
}
*/

/*// Задача 45:
Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
///
int getInt(string str){ // Получение целого числа с консоли с текстом запроса

    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int[] getArrRnd(int n, int s, int e){ // Генерация массива заданного размера со значениями заданного диапазона

    int[] mass = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        mass[i] = rnd.Next(s, e);
    }
    return mass;
}

int[] copyArr(int[] arrbase){

    int[] arr2 = new int[arrbase.Length];

    for (int i = 0; i<arrbase.Length; i++){
        arr2[i] = arrbase[i];
    }
    return arr2;
}


int[] arr = getArrRnd(getInt("Введите число элементов: "), 0, 100);

int[] arr2 = copyArr(arr);

Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(string.Join(", ", arr2));
// */

/*// Задача 44:
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
Если введено отрицательное число то задается ряд в обратном порядке
///

int getInt(string str){ // Получение целого числа с консоли с текстом запроса

    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int[] getFiboArr(int n){
    if (n == 0){
        return;

    } else {
        int lngth = Math.Abs(n);
        int[] fibo = new int[lngth];
        
        switch(lngth){
            default:
                
                int istt = n>0?2:lngth-1;
                int iend = n>0?lngth-1:2;

            case 2: fibo[n>0?1:0]=1;
            case 1: fibo[n>0?0:1]=0;
                if (lngth>2){
                    for (int i = 2; i < lngth; i++){
                        fibo[i-lngth-1]=fibo[i-1+lngth]+fibo[i-2+lngth];
                    }                     
                }
        }
    }

    return fibo;
}

int[] Fibo = getFiboArr(getInt("Введите длинну ряда Фибоначи"));

Console.WriteLine(string.Join(", ", Fibo));

//*/

/*// Задача 41:
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

///

int[] getArrConsole(){
    Console.Write($"\nВведите элементы массива через пробел или запятую: ");
    string[] str = Console.ReadLine().Split(' ',',');
    int[] arr = new int[str.Length];
    for(int i=0; i<str.Length; i++) arr[i] = int.Parse(str[i]);
    return arr; 
}

int countPos(int[] arr){
    int count=0;
    for(int i=0; i<arr.Length; i++){
        if(arr[i]>0) count++;
    }
    return count;
}

int[] arr = getArrConsole();
Console.Write(string.Join(", ", arr)+" -> "+countPos(arr));

//*/

/*// Задача 43:
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Попытка решения через класс.
// using System.Drawing;
// using System.Runtime.InteropServices;

// lineDB2d line1 = new lineDB2d();
// line1.setLineConsole();
// line1.PrintLine();

// lineDB2d line2 = new lineDB2d();
// line2.setLineConsole();
// line2.PrintLine();
// System.Console.WriteLine('[' + string.Join(", ", line1^line2) + ']');

// class lineDB2d {
    
//     private double _k,_b;
//     static int count;

//     public lineDB2d(double gK=0, double gB=0)
//     {
//         _k= gK;
//         _b= gB;
//         count++;
//     }
//     ~lineDB2d(){
//         // System.Console.Write($"{count}");
//         count--;
//     }
//     public void PrintLine(){
//         switch (( Math.Abs(_k), Math.Abs(_b))){
//             case (>0, >0):
//                 System.Console.WriteLine($"y = {_k}x {(_b>0?"+":"-")} {Math.Abs(_b)}");
//                 break;
//             case (0, >0 ):
//                 System.Console.WriteLine($"y = {_b}");
//                 break;
//             case (>0 , 0 ):
//                 System.Console.WriteLine($"y = {_k}x");
//                 break;
//             default:
//                 System.Console.WriteLine($"y = 0");
//                 break;

//         }
//     }
//     public double getK() => _k;

//     public static double[] operator ^(lineDB2d l1, lineDB2d l2){
//         if (l1._k==l2._k)
//         {
//             System.Console.WriteLine("Прямые параллельны");
//             return [null,null];
//         } 
//         else {
//             double x = (l2._b - l1._b) / (l1._k - l2._k);
//             double y = l1._k * x + l1._b;
//             System.Console.WriteLine($"Точка пересечения - [{x},{y}]");     
//             return [x, y];       
//         }
//     }
//     public double getB() => _b;
    
//     private double getConsole(string str){
//         System.Console.Write(str);
//         return Convert.ToDouble(Console.ReadLine());
//     }
//     public void setLineConsole(){ // Получение целого числа с консоли с текстом запроса
//         Console.WriteLine($"(определение прямой №{count}) Линии на плоскости имеют формат y = k{count}*x + b{count} ");
//         _k = getConsole($"Введите коэффециент k{count}: ");
//         _b = getConsole($"Введите смещение b{count}: ");
//     }
// }
//*/

using System.Text;

double getDB(string str = "\n"){ // Получение целого числа с консоли с текстом запроса
    Console.Write(str);
    return Convert.ToDouble(Console.ReadLine());
}

double[] intrseclines(double[] line2d1, double[] line2d2){
    double[] pointInrsec = new double[2];
    pointInrsec[0] = (line2d2[1]-line2d1[1])/(line2d1[0]-line2d2[0]);
    pointInrsec[1] = line2d1[0]*pointInrsec[0]+line2d1[1];
    return pointInrsec;
}

double[] line1 = new double[2];
line1[0] = getDB("k1 = ");
line1[1] = getDB("b1 = ");
double[] line2 = new double[2];
line2[0] = getDB("k2 = ");
line2[1] = getDB("b2 = ");

// Console.WriteLine('[' + string.Join(", ", line1 ) + ']');
// Console.WriteLine('[' + string.Join(", ", line2 ) + ']');
Console.WriteLine(" -> "+'(' + string.Format("{f4}")Join("\t", intrseclines( line1, line2 ) ).Replace(',','.') + ')');


//*/