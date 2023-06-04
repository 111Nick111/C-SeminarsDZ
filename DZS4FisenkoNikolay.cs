// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную 
//степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.WriteLine("Задача 25. Введите число А");
// int numA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Задача 25. Введите степень числа-В");
// int numB = Convert.ToInt32(Console.ReadLine());
// int resultExp()
// {
// int exp = 1;
// int count = 1;
// while (count<=numB)
// {
//     exp=exp*numA;
//         count++;
// }
// return exp;
// }
// Console.Write($"А в степени В =  {resultExp()}");


// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Задача 27. Введите целое число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum =0;
// while (num>0)
// {
//     int rem=num%10;
//     Console.Write ($"  +, {rem}");
//     num=num/10;
//     sum=sum+rem;
// }
// Console.WriteLine ();
// Console.WriteLine ($"Итого, сумма всех цифр в числе равна, {sum}");


// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


//---------------------------------- Задача 29---------------------------------
//  Напишите программу, которая задаёт массив из 8 
//элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine ("Задача 29, создаем массив из 8 элементов случайным образом:");
int [] array=new int[8];

for(int i =0;i<array.Length;i++)
{
    array[i]=new Random().Next();
    Console.WriteLine(array[i]+" элемент ");
}

