
void Task10(){
    Console.Write("Введите 3-х значное число: ");
    Console.WriteLine("{0}", (Convert.ToInt32(Console.ReadLine())%100)/10);
}

void Task13(){
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num/100!=0){
            int n=100;
            while (num/n!=0){
                n*=10;
            }
            Console.WriteLine("{0}", (num%(n/100))/(n/1000));
        }
        else{
            Console.WriteLine("Третьей цифры нет");
        }
}


Console.Write(@"Доступные номера задач:
    10 Вывод 2-ой цифры 3-х значного числа.
    13 Вывод 3-ей цифры числа или сообщение ""Третьей цифры нет"".
    15 Является ли введеный номер дня недели выходным( 1-понедельник).
Введите номер задачи: ");
int ntask = Convert.ToInt32(Console.ReadLine());
switch(ntask){
    case 10:{
        Task10();
        break;
    };
    case 13:{
        Task13();
        break;
    };
    case 15:{
        // Task15();
        Console.Write("15");
        break;
    };
    default:{
        Console.WriteLine("Попробуй еще раз.");
        break;
    };
}