// Задача 54: Задайте двумерный массив. Напишите
//  программу, которая упорядочит по убыванию элементы
//   каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// Создание массива
// Console.WriteLine("Задача 54, введите количество строк массива");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задача 54, введите количество столбцов массива");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int [,] array= new int[rows,colomns];

// // Метод заполняет массив
// void GetArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//          for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j]= new Random().Next(0,11);
//         }
//     }
// }
// // Метод выводит массив
// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//          for (int j = 0; j < array.GetLength(1); j++)
//         {
//            Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// // Метод упорядочивает числа в строках по убыванию
// int count = colomns;
// int k=1;
// void DescSortArray()
// {
//     for (k=1; k<count; k++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//             {
//             for (int j = 0; j < (array.GetLength(1)-1); j++)
//             {
//                 int maxnumJ =j;
//                 int temp =array[i,j];
//                 if (array[i,j]<array[i,j+1])
//                 maxnumJ = j+1;
//                 array[i,j] = array[i,maxnumJ];
//                 array[i,maxnumJ] = temp;
                                            
//             }  
                  
//         }
//     }    
// }
// пока не пришло прозрение, пришлось много ломать дров, 
// хотя в своей сущности, задача оказалась простой...
// GetArray();
// PrintArray();
// DescSortArray();
// Console.WriteLine("_____________");
// PrintArray();



// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку
//   с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка

// Создание массива
// Console.WriteLine("Задача 56, введите количество строк массива");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задача 56, введите количество столбцов массива");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int [,] array= new int[rows,colomns];
// int [] minSumStroke = new int [rows];

// // // Метод заполняет массив
// void GetArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//          for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j]= new Random().Next(0,11);
//         }
//     }
// }
// // // Метод выводит массив
// void PrintArray()

// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//          for (int j = 0; j < array.GetLength(1); j++)
//         {
//            Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }


// void SummRows()
// {
//     int count =0;
//     int minSum =0;
    
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//        int sumStroke =0; 
//          for (int j = 0; j < array.GetLength(1); j++)
//             {  
//             sumStroke=sumStroke + array[i,j];          
//             }  
//             Console.WriteLine("  "+sumStroke);         
        
//             if (i==0)
//             {
//             minSum=sumStroke;
//             }
//             else if (sumStroke<minSum)
//             {
//             minSum=sumStroke;
//             count = i+1;
//             }
//     }
//         string line = string.Empty;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//         line += count + " ";
//         }
//         Console.WriteLine($"Номер строки с минимальной суммой элементов равен {count} ");   
// }

// GetArray();
// PrintArray();
// SummRows();
// Console.WriteLine("_____________");



// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//Создание матриц
// Console.WriteLine("Задача 58, Задайте размерность матриц");
// int rowscol = Convert.ToInt32(Console.ReadLine());

// int [,] matrix1= new int[rowscol,rowscol];
// int [,] matrix2= new int[rowscol,rowscol];
// int [,] matrix3= new int[rowscol,rowscol];
// // Метод заполняет массив
// void GetMatrix(int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().Next(0,11);
//         }
//     }
// }
// // Метод выводит массив
// void PrintMatrix(int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            Console.Write(matrix[i,j]+"  ");
//         }
//         Console.WriteLine();
//     }
// }
// void MultMatrix()
// {
//             for (int i = 0; i < matrix3.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matrix3.GetLength(1); j++)
//                 {
//                     for (int k = 0; k < matrix3.GetLength(0); k++)
//                     {
//                         matrix3[i,j] += matrix1[i,k] * matrix2[k,j];
//                     }
//                 }
//             }      
// }
// Console.WriteLine("Матрица1");
// GetMatrix(matrix1);
// PrintMatrix(matrix1);
// Console.WriteLine("_________");
// Console.WriteLine("Матрица2");
// GetMatrix(matrix2);
// PrintMatrix(matrix2);
// Console.WriteLine("Вывод результата произведения двух матриц:");
// MultMatrix();
// PrintMatrix(matrix3);


// Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить
//  массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("Задача 60, Создается трехмерный массив");
// int[,,] array3D = new int [2,2,2];

// void FillArray(int[,,] arr)
// {
//     int count =15;
//     for (int i=0; i<arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 for (int k = 0; k < arr.GetLength(2); k++)
//                 {
//                     arr[i,j,k] +=count;
//                     count +=5;
//                 }
                
//             }
//         }

// }
// void PrintIndex(int[,,] arr)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 System.Console.Write($"{array3D[i,j,k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }
// //не совсем понятно, почему параметр arr в объявлении метода 
// // в одном случае прописыватеся как arr в теле метода, а в 
// // другом случае - мы уже прописываем имя массива вместо arr??
// // строки 161 164 166 168 супротив строк: 178 180 182 185 ???
// FillArray(array3D);
// PrintIndex(array3D);



// Задача 62. Напишите программу, которая заполнит
//  спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Задача 62");

int [,] array= new int[4,4];

// // Метод заполняет массив
// 
    
void GetArray()
{
    array[0,0]=1;
    int count =01;
    
    for (int i = 0;  i<4; i++)
    {
         for (int j = 1; j < 4; j++)
        {
            array[i,j]= array [0,0] + count;
            count ++;
        }
    }
}
//Метод выводит массив
void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}
GetArray();
PrintArray();
