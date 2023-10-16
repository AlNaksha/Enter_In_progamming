int getInt(string str="")                               // Получение целого числа с консоли с текстом запроса
    {
        Console.Write(str);
        return Convert.ToInt32(Console.ReadLine());
    }

/*// Задача 63:
    Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
    N = 5 -> "1, 2, 3, 4, 5"
    N = 6 -> "1, 2, 3, 4, 5, 6"
    //*/ 

    void roadToN(int n=1){
        if (n==0) return;
        roadToN(n-1);
        System.Console.Write($"{n}\t");
    } 
    void Task63(){
        int n = getInt("Введите n = ");
        System.Console.Write($"Получается ряд: ");
        roadToN(n);
    }
//*/ 

/*// Задача 64:
    Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

    //*/ 
    void roadNTo1(int n=1){
        if (n==0) return;
        System.Console.Write($"{n}\t");
        roadNTo1(n-1);
    } 

    void Task64(){
        int n = getInt("Введите n = ");
        System.Console.Write($"Получается ряд: ");
        roadNTo1(n);
    }

    //*/ 

/*// Задача 65:
    Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
    M = 1; N = 5 -> "1, 2, 3, 4, 5"
    M = 4; N = 8 -> "4, 6, 7, 8"
    //*/

    void roadMToN(int n=2, int m=1){
        if (n<m) return;
        roadMToN(n-1,m);
        System.Console.Write($"{n}\t");
    }

    void Task65(){
        int m = getInt("Введите M = ");
        int n = getInt("Введите N = ");
        System.Console.Write($"Получается ряд: ");
        if (n<m){
            roadMToN(m,n);
        }else{
            roadMToN(n,m);
        }
    }
//*/

/*// Задача 66:
    Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
    //*/ 

    int summToN(int n=2, int m=1){
        if (n<m) return 0;
        return n + summToN(n-1,m);
    }

    void Task66(){
        int m = getInt("Введите M = ");
        int n = getInt("Введите N = ");
        int sum;
        if (n<m) sum = summToN(m,n);
        else sum = summToN(n,m);
        
        System.Console.WriteLine($"Сумма чисел = {sum}");
    }
    //*/ 

/*// Задача 67:
    Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
    453 -> 12
    45 -> 9
    //*/ 

    int summDigits(int n){
        if (n==0) return 0;
        return n%10 + summDigits(n/10);
    }

    void Task67(){
        int n = getInt("Введите N = ");
        System.Console.WriteLine($"Сумма цифр числа = {summDigits(n)}");
    }
    //*/ 

/*// Задача 68:
    Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29
    //*/ 
    int AccermansFunc(int m,int n){
        if (m==0) {
            return n+1;
        }

        if (m>0){
            if (n==0){
                return AccermansFunc(m-1,1);
            }else{
                
            return AccermansFunc(m-1,AccermansFunc(m,n-1));
            }
        }
        return 0;

    }

    void Task68(){
        int m = Math.Abs(getInt("Введите m = "));
        int n = Math.Abs(getInt("Введите n = "));
        System.Console.WriteLine($"Результат функции = {AccermansFunc(m,n)}");
    }
    //*/

/*// Задача 69:
    Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
    A = 3; B = 5 -> 243 (3⁵)
    A = 2; B = 3 -> 8
    //*/

    int Pow(int a, int b){
        // a - возводимое b - степень
        if (b==0) return 1;
        return a * Pow(a, b-1);
    }
    void Task69(){
        int a = getInt("A = ");
        int b = getInt("B = ");
        System.Console.WriteLine($"\t{a}^{b} = {Pow(a,b)}");
    }
    //*/

/// 
    Console.Write(@"Доступные номера задач:
    63. Вывод натурального ряда чисел от 1 до N (реккурентно)
    64. Вывод натурального ряда чисел от N до 1 (реккурентно)
    65. Вывод натурального ряда чисел от M до N (реккурентно)
    66. Вывод суммы натурального ряда чисел от M до N (реккурентно)
    67. Сумма цифр числа ( реккурентно)
    68. Функция Аккермана
    69. Реккурентное возведение первого числа в степень второго
Введите номер задачи: ");
    int ntask = Convert.ToInt32(Console.ReadLine());
    switch(ntask){
        case 63:{
            Task63();
            break;
        };
        case 64:{
            Task64();
            break;
        };
        case 65:{
            Task65();
            break;
        };
        case 66:{
            Task66();
            break;
        };
        case 67:{
            Task67();
            break;
        };
        case 68:{
            Task68();
            break;
        };
        case 69:{
            Task69();
            break;
        };
        default:{
            Console.WriteLine("Попробуй еще раз.");
            break;
        };
    }
    //*/