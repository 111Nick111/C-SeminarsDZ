//        Урок 5. Функции и одномерные массивы

// Задача 34: Задайте массив заполненный случайными
//  положительными трёхзначными числами. Напишите
//   программу, которая покажет количество чётных 
//   чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Задача 34: Создадим массив Random трехзначные number");
// int [] array= new int [5];
//                            //int [] array =new int[4]{345,897,568,234}; -это строка для ручного ввода, читай как комментарий
// int evenNum=0;

// for(int i=0;i<array.Length; i++)
// {
//     array[i] = new Random().Next(100,1000);
//     Console.Write(" [");
//     Console.Write(array[i]);
//     Console.Write("] ");
// }
// Console.WriteLine();
// for(int i=0;i<array.Length; i++)
// {
//     if (array[i]%2==0)
//     evenNum = evenNum +1;
// }
// Console.WriteLine("КОЛИЧЕСТВО ЧЕТНЫХ ЧИСЕЛ В МАССИВЕ = " +evenNum);


// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих
//  на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Задача 36: Сумма элементов стоящих на нечетных позициях");
// int [] array= new int [5];
//                            //int [] array =new int[4]{3, 7, 23, 12}; -это строка для ручного ввода, читай как комментарий
// int oddsum=0;

// for(int i=0;i<array.Length; i++)
// {
//     array[i] = new Random().Next(-100,100);
//     Console.Write(" [");
//     Console.Write(array[i]);
//     Console.Write("] ");
// }
// Console.WriteLine();
// for(int i=0;i<array.Length; i++)
// {
//     if (i%2==1)
//     oddsum = oddsum + array[i];
// }
// Console.WriteLine("Сумма элементов массива с нечетными индексами равна " +oddsum);


// Задача 38: Задайте массив вещественных чисел. Найдите
//  разницу между максимальным и минимальным элементом
//   массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Задача 38: Разность max-min double num");
double [] arrFloat= new double [5];
                          //double [] arrFloat= new double[5]{3.22, 4.2, 1.15, 77.15, 65.2}; //-это строка для ручного ввода, читай как комментарий
double diffNum=0;
double max = arrFloat [0];

for(int i=0;i<arrFloat.Length; i++)
{
    arrFloat[i] = (Math.Round(new Random().NextDouble(),3))*100; //или +new Random/// 
    Console.Write(" [");
    Console.Write(arrFloat[i]);
    Console.Write("] ");
}
Console.WriteLine();
for(int i=0;i<arrFloat.Length; i++)
{
    if (arrFloat[i] >max)
        max=arrFloat[i];
}
Console.WriteLine("maxимальное значение среди чисел = " +max);
double min = arrFloat [0];
for(int i=0;i<arrFloat.Length; i++)
{
    if (arrFloat[i] <min)
        min=arrFloat[i];
}
Console.WriteLine("minимальное значение среди чисел = " +min);
    diffNum = max -min;
Console.WriteLine("Разность max - min = " +diffNum);
