//Console.WriteLine("213123Hello, World!");
Console.WriteLine("Введите номер задачи: ");
int ntask = Convert.ToInt32(Console.ReadLine());
switch(ntask){
    case 1:{
        Console.WriteLine("1");
        break;
    };
    case 2:{
        Console.WriteLine("2");
        break;
    };
    case 3:{
        Console.WriteLine("3");
        break;
    };
    case 4:{
        Console.WriteLine("4");
        break;
    };
    default:{
        Console.WriteLine("else");
        break;
    };
}