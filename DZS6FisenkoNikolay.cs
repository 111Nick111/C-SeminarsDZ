// // Урок 6. Одномерные массивы. Продолжение

// // // Задача 41: Пользователь вводит с клавиатуры M
// //  чисел. Посчитайте, сколько чисел больше 0 ввёл 
// //  пользователь.
// // // 0, 7, 8, -2, -2 -> 2
// // // 1, -7, 567, 89, 223-> 3
// Честно списанная программа, спасибо за метод! Вначале было озадачился
// созданием бесконечного массива через стринг и на том подвис...
// но в условии не сказано как это должно реализовываться! Спасибо!

int result=0;
string exit = "+";
int Count()
{
Console.WriteLine("Введите число, но если требуется выход из программы, нажмите "+ exit);
string num = (Console.ReadLine());
Console.WriteLine();
if (num==exit)
{
    Console.WriteLine("Вы вышли из программы");
    return result;    
}
int digit =Convert.ToInt32(num);
if (digit>0)
{
    result ++;
}
Console.WriteLine($"Количество положительных чисел введенных пользователем = {result}");
return Count();
}
Count();




// // Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1,
//   b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Задача 43: Введите коэффициент b1");
// double b1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Задача 43: Введите коэффициент k1");
// double k1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Задача 43: Введите коэффициент b2");
// double b2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Задача 43: Введите коэффициент k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// if (k1!=k2)
// {
// double numX = (b2-b1)/(k1-k2);// k1*x + b1=k2*x + b2 ; k1*x-k2*x=b2-b1  ; x(k1-k2)=b2-b1 ; x=(b2-b1)/(k1-k2) ; 
// double numY = k2 * numX + b2;
// Console.WriteLine($"Точка пересечения прямых имеет координаты x={numX}, y={numY}");
// }
// else
// {
//   Console.WriteLine("Прямые не пересекаются");  
// }