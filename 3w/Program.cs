// Console.WriteLine("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// System.Console.WriteLine(Convert.ToString(number).Length);

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int writeMult(int num){
//     int mult = 1;
//     for(int i=1; i<=num;i++){
//         mult*=i;
//     }
//     return mult;
// }

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(writeMult(number));

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int n=8;
// int[] mass= new int[n];
// for (int i=0; i<n;i++){
//     mass[i]= new Random().Next(0,2);
// }

// for (int i=0; i<n;i++){
//     System.Console.Write($"{mass[i]},");
// }
// 1 Вариант решения
// Console.WriteLine("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int count = 0;
// if (number == 0)
// {
//     Console.WriteLine(1);
// }
// else
// {
//     while (number > 0)
//     {
//         count++;
//         number /= 10;
//     }

//     Console.WriteLine(count);
// }

//2 Вариант 

// Console.WriteLine("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// string num = Convert.ToString(number); // 123 = "123"
// System.Console.WriteLine(num.Length); // ""

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// if (number == 0)
// {
//     Console.WriteLine(1);
// } else
// {
//     while (number > 0)
//     {
//         count++;
//         number /= 10;
//     }

//     Console.WriteLine(count.ToString());
// }
////////////////////////////////////////////
// int[] mass = new int[8];
// Random rnd = new Random();

// for (int i = 0; i < mass.Length; i++)
// {
//     mass[i] = rnd.Next(0, 2);
// }

// System.Console.WriteLine('[' + string.Join(", ", mass) + ']');
////////////////////////////////////////////

// int[] FillArray(int[] arr, Random rnd)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(0, 2);
//     }
//     return arr;
// }

// int[] mass = new int[8];
// Random rnd = new Random();

// for (int i = 0; i < mass.Length; i++)
// {
//     mass[i] = rnd.Next(0, 2);
// }

// System.Console.WriteLine('[' + string.Join(", ", FillArray(mass, rnd)) + ']');