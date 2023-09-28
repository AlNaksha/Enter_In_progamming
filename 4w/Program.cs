
int getInt(string str){
    Console.Write($"\n"+str+" число:");
    return Convert.ToInt32(Console.ReadLine());
}

int Pownum (int a, int b) {
    if(b==0) return 1;
    return a*Pownum(int a, int b-1);
}

void Task25(){
    System.Console.WriteLine($"Результат: {Pownum(getInt("Первое"),getInt("Второе")) }");
}



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