// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// //и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)
// // 3, 5 -> 243 (3⁵)     //2, 4 -> 16

// double PowMe(int x, int y)
// {
//     double res = 1;
//     if (y > 0)
//     {
//         for (int i = 1; i <= y; i++)
//         { res = res * x; }
//     }
//     else if (y < 0 && x != 0)
//     {
//         for (int i = -1; i >= y; i--)
//         { res = res / x; }
//     }
//     //для степени ноль результат = 1, он не меняется
//     return res;
// }

// Console.Write("Введите основание степени: ");
// int bas = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите показатель степени: ");
// int power = Convert.ToInt32(Console.ReadLine());

// if (bas == 0 && power <= 0) //Хотя есть мнение, что 0^0 = 1
// { Console.WriteLine("Математическое выражение не имеет смысла"); }
//  else
//  {
// double done = PowMe(bas, power);
// Console.WriteLine($"Результат возведения в степень = {Math.Round(done, 6)}");
//  }




// //Задача 27: Напишите программу, которая принимает на вход число и 
// //выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)
// // 452 -> 11     82 -> 10     9012 -> 12

// int Numero(int a)
// {
//     int nsum = a % 10;
//     while ((a / 10) > 0)
//     {
//         a = a / 10;
//         nsum = nsum + (a % 10);
//     }

//     return nsum;
// }

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n < 0) n = n * (-1);

// Console.WriteLine($"Сумма цифр числа {n} равна {Numero(n)}");




//Задача 29: Напишите программу, которая задаёт массив из произвольного 
// кол-ва элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



void PrintArray(int[] arr)
{ 
    for (int i = 0; i < arr.Length; i++)
    { Console.Write($"{arr[i]} "); }
}

int[] FillArray(int len)
{
    int[] yourAr = new int[len];
    for (int i = 0; i < len; i++)
    {
        Console.Write($"Введите значение {i}-го элемента ");
        yourAr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return yourAr;
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

if(size<=0) Console.WriteLine("Размер массива должет быть больше 0");
else PrintArray(FillArray(size)); 
Console.WriteLine(); //для красоты