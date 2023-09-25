//Console.WriteLine("213123Hello, World!");

void Task2(){
    Console.Write("\nПервое число:");
    int NumA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Второе число:");
    int NumB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (NumA>NumB) {
        Console.Write("Максимальное значение: {0}\nМинимальное: {1}", NumA, NumB);
    }
    else{
        Console.Write("Минимальное значение: {0}\nМинимальное: {1}", NumB, NumA);
    }
}

void Task4(){
    Console.Write("\nВведите последовательно 3 числа: ");

    int[] Mass = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToArray(); // да, подглядел
    Console.Write("Максимальное число: {0}", Mass.Max());

    // int i=0;
    // int[] Mass = new int[3];
    // while(i<3){
    //     Mass[i] = Convert.ToInt32(Console.ReadLine());
    //     i++;
    // }
    // Console.Write("{0} {1} {2}", Mass[0], Mass[1], Mass[2]);

}

Console.Write(@"Доступные номера задач:
    2 Максимальное из двух целых чисел.
    4 Максимальное из трех целых чисел.
    6 Проверка на четность.
    8 Вывод всех четных до вводимого числа.
Введите номер задачи: ");
int ntask = Convert.ToInt32(Console.ReadLine());
switch(ntask){
    case 2:{
        Task2();
        break;
    };
    case 4:{
        Task4();
        break;
    };
    case 6:{
        Console.WriteLine("3");
        break;
    };
    case 8:{
        Console.WriteLine("4");
        break;
    };
    default:{
        Console.WriteLine("Попробуй еще раз.");
        break;
    };
}