﻿// Задача 10: Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("(Задача 10) Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num>99 && num<1000)
{
    int secnum= num/10;
    Console.Write("Вторая цифра числа = ");
    Console.WriteLine(secnum%10);
}
else
{
Console.WriteLine("Число не трехзначное, повторите операцию ввода перезапустив программу");
}

//Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей 
// цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("(задача 13) Пожалуйста введите число ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num3/100==0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (num3>1000)
    {
        num3=num3/10;
    }
    Console.Write("Третья цифра числа = ");
    Console.WriteLine(num3%10);
}

// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("(задача 15) Пожалуйста введите цифру от 1 до 7 включительно ");
int numwknd= Convert.ToInt32(Console.ReadLine());

if (numwknd ==6 || numwknd ==7)
{
    Console.WriteLine("Друг - это выходной, пишу ДА");
}
else
{
        Console.WriteLine("Друг - это будний день, пишу НЕТ");
}
