// Урок 7. Двумерные массивы

// . Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Задача 47, введите количество строк массива");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задача 47, введите количество столбцов массива");
// int colomns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix= new double[rows,colomns];
// // double i = new Random().NextDouble()+new Random().Next(-10,11); // памятка // заполнение индекса числом с плавающей запятой + целое число // памятка
// // Console.WriteLine(i);
// // double j = new Random().NextDouble()+new Random().Next(-10,11); // памятка // заполнение индекса числом с плавающей запятой + целое число // памятка
// // Console.WriteLine(j);

// // Метод заполняет массив
// void Array()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().NextDouble()+new Random().Next(-100,101);
//         }
//     }
// }
// // Метод выводит массив
// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            Console.Write(Math.Round (matrix[i,j],3)+" | ");
//         }
//         Console.WriteLine();
//     }
// }

// Array();
// PrintArray();

// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же 
// указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Задача 50, задайте размер массива");
// int rows = Convert.ToInt32(Console.ReadLine());
// int colomns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix= new int[10,10];

// // Метод заполняет массив
// void Array()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().Next(-100,100);
//         }
//     }
// }
// // Метод выводит массив
// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            Console.Write(matrix[i,j]+" | ");
//         }
//         Console.WriteLine();
//     }
// }
// // Метод ищет значение позиции указанной пользователем

// void SrchNum()
// {
//     Console.WriteLine("Введите номер строки ");
//     int X = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите номер столбца ");
//     int Y = Convert.ToInt32(Console.ReadLine());
//         if (X>matrix.GetLength(0) || Y>matrix.GetLength(1))
//             {
//             Console.WriteLine("Такого элемента нет, повторите ввод изменив значения строк и столбцов");             
//             }
//                 else 
//                     {
//                     Console.WriteLine("Значение элемента в данной позиции = " +matrix[X-1,Y-1]);     
//                     }
// }
// Array();
// PrintArray();
// SrchNum();

// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом
//   столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 
// 3,6; 3.

// Console.WriteLine("Задача 52, задайте размер массива");
// int rows = Convert.ToInt32(Console.ReadLine());
// int colomns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix= new int[rows,colomns];
// // Метод заполняет массив
// void Array()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().Next(1,10);
//         }
//     }
// }
// // Метод выводит массив
// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            Console.Write(matrix[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// // Метод рассчитывает среднее арифметическое элементов столбца
// void ArythMeanColomns()
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         double middleArythColomns =0;
//         double sumColomns=0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             sumColomns = sumColomns+matrix[i,j];
//             //Console.Write(sumColomns+" сумма столбца ");
//         }
//     middleArythColomns = sumColomns/rows; 
//     Console.Write($"Среднее арифметическое столбца {j+1}:");  
//     Console.Write(" " + Math.Round (middleArythColomns,3)); 
//     Console.WriteLine();
//     }
//  }

// Array();
// PrintArray();
// ArythMeanColomns();
