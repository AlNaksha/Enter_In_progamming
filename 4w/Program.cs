
int getInt(string str){ // Получение целого числа с консоли с текстом запроса
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int Pownum (int a, int b) { // Возведение "а" в степень "б" циклически
    int res=a;
    for(int i=1;i<b;i++){
        res*=a;
    }
    return res;
}

void Task25(){
    System.Console.WriteLine($"Результат: {Pownum(getInt("Первое число: "),getInt("Второе число: ")) }");
}

////////////////////////////////////////////////////////////////

/* реккурентные функции
// подсчет цифр числа( знак влияет только на первую цифру)
int sumDSONR(int num){ // summ digits fo number recursion 
    if (num/10==0) return num;
    if (num>0) return num%10 + sumDSONR(num/10);
    else return -num%10 + sumDSONR(num/10);
}

int numD(int num){
    if (num/10==0) return 1;
    return 1+numD(num/10);
}
*/

int sumDSON(int num){ // summ digits fo number
    int res=0;
    int d=1;
    // System.Console.WriteLine(numD(num));
    for (; d < Math.Abs(num/10); d*=10){
        res += (num/d)%10;
        // System.Console.WriteLine($"{res}");
    }
    return Math.Abs(res)+num/d;
}

void Task27(){
    // System.Console.WriteLine(sumDSONR(getInt("Введите число: ")));
    System.Console.WriteLine(sumDSON(getInt("Введите число: ")));
}

////////////////////////////////////////////////////////////////

int[] getArrRnd(int n, int s, int e){// Генерация массива заданного размера со значениями заданного диапазона
    int[] mass = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        mass[i] = rnd.Next(s, e);
    }
    return mass;
}

int[] getArrConsole(){
    Console.Write($"\nВведите элементы массива через пробел или запятую: ");
    string[] str = Console.ReadLine().Split(' ',',');
    int[] arr = new int[str.Length];
    for(int i=0; i<str.Length; i++) arr[i] = int.Parse(str[i]);
    return arr; 
}

void Task29(){
    Console.Write("\nВариант генерации:\n    1 Случайно\n    2 Вручную\nВы выбираете: ");
    int ntask = Convert.ToInt32(Console.ReadLine());
    switch(ntask){
        case 1:{
            System.Console.WriteLine('[' + string.Join(", ", getArrRnd(getInt("\nВведите число элементов: "), getInt("Минимальное значение: "), getInt("Предельное значение: "))) + ']');
            break;
        }
        case 2:{
            System.Console.WriteLine('[' + string.Join(", ", getArrConsole()) + ']');
            break;
        }
        default:{
            Console.WriteLine("Попробуй еще раз.");
            break;
        }
    }
}

////////////////////////////////////////////////////////////////

Console.Write(@"Доступные номера задач:
    25 Возведение первого вводимого числа в степень второго.
    27 Суммирование цифр передаваемого числа.
    29 Создание массива(8 элементов) и вывод на экран(консоль)
Введите номер задачи: ");
int ntask = Convert.ToInt32(Console.ReadLine());
switch(ntask){
    case 25:{
        Task25();
        break;
    };
    case 27:{
        Task27();
        break;
    };
    case 29:{
        Task29();
        break;
    };
    default:{
        Console.WriteLine("Попробуй еще раз.");
        break;
    };
}