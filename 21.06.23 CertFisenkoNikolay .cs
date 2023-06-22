//          Урок 9. Рекурсия
// Задача 64: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке
//   от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// System.Console.WriteLine("Задача 64: Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int endNum=1;
// System.Console.WriteLine(PrintNumbers (num, endNum)); 
// string PrintNumbers(int num1, int num2)
// {
//     if (num1==num2)
//     {
//         return num1.ToString();
//     }
//     return(num1+ " "+ PrintNumbers(num1-1,num2));
// }
//___________________________________________________

// Задача 66: Задайте значения M и N. Напишите 
// программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Задача 66:  Введите число M");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int numN = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(PrintSum(numM, numN));

// int PrintSum(int num1, int num2 )
// {
//     if (num1==num2)
//     {   
//         return num1; 
//     }
//     if (num1>num2)
//     {
//         return (num1+PrintSum((num1-1),num2));
//     }
//     return (num1+PrintSum((num1+1),num2));

// }
//__________________________________________________

// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два
//  неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Задача 68:  Вычисляем функцию Аккермана! Введите число m");
// int numm = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n");
// int numn = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(PrintAf(numm, numn));

// int PrintAf(int num1, int num2 )
// {
//     if (num1==0)
//     {   
//         return num2+1; 
//     }
//     if (num2==0)
//     {
//         return PrintAf(num1-1,1);
//     }
//     return PrintAf((num1-1),PrintAf(num1,(num2-1)));

// }

