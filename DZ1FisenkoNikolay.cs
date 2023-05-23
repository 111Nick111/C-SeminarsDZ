// Урок 1. Знакомство с языком программирования С#

// _______________________________________________Задача 1(2)_______________________________________________________
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Задание 1. Введите первое число");
int numA=Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введи второе число");
int numB=Convert.ToInt32(Console.ReadLine());

if (numA>numB)
{
    Console.Write("Большее число, max = ");
    Console.WriteLine(numA);
}
else
{
    Console.Write("Большее число, max = ");
    Console.WriteLine(numB);
}
//_______________________________________________Задача 2(4)__________________________________________________________

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Задание 2. Введите первое число");
int num1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введи второе число");
int num2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введи третье число");
int num3=Convert.ToInt32(Console.ReadLine());

int maxnum = num1;
    if (num2>maxnum) maxnum=num2;
    if (num3>maxnum) maxnum=num3;

Console.Write ("Максимальное из трех чисел равно: ");
Console.WriteLine (maxnum);

//______________________________________________________Задача 3(6)_________________________________________________________
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Здравствуй! Введи, пожалуйста, число, а я определю четное оно или нет");
int num=Convert.ToInt32(Console.ReadLine());

    if (num%2==0)
{
        Console.Write ("Число ");
        Console.Write (num);
        Console.Write (" - четное");
}
    else
{
        Console.Write ("Число ");
        Console.Write (num);
        Console.Write (" - нечетное");
}

//___________________________________________________Задача 4(8)________________________________________________________________

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine ();
Console.WriteLine("Здравствуй! Введи, пожалуйста, число, а я немного поколдую и выведу только четные на твой монитор");
int numN=Convert.ToInt32(Console.ReadLine());

int evennum= 2;

while(evennum<=numN)
{
     Console.Write(evennum+"  ,");
    evennum=evennum+2;
}
Console.WriteLine ();

Console.WriteLine ("The Happy End of DZ Nick Fisenko");
