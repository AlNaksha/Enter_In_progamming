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

/*//Задача 43:
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*///
int getInt(string str){ // Получение целого числа с консоли с текстом запроса

    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int[] intrsec(int[] line2d1, int[] line2d2){
    int x = (line2d1[2]-line2d2[2])/(line2d2[1]-line2d1[1]);
    int y = line2d1[1]*x+line2d1[2];
    return {x, y};
}

Console.WriteLine(string.Join(", ", intrsec({getInt("k1 = "),getInt("b1 = ")}, {getInt("k2 = "),getInt("b2 = ")})));


//*/