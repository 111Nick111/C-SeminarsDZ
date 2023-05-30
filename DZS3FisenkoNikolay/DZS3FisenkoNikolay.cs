//Задача 19
//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("(Задача 19) Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());

    int num1=num/10000;
    //Console.WriteLine(num1);
    int num2=num/1000;
    //Console.WriteLine(num2);
    int num3=num/10;
    //Console.WriteLine(num3);
// Написал программу-костыль, работает по 5-значному числу,
// если ввести иное - не сработает. Нужно писать цикл и
// продумывать более серьезный алгоритм просчета и сравнения.
// Нужно чутка больше времени, не успеваю) Просьба понять и простить.
if ((num1%10==num%10) && (num2%10==num3%10))
{
    Console.WriteLine("Введенное число является палиндромом");
}
else
{
    Console.WriteLine("Введеное число не относится к палиндромному");
}

//Задача 21
//Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Задача 21");
Console.WriteLine("Введите число X1");
int X1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Y1");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Z1");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число X2");
double X2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число Y2");
int Y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Z2");
int Z2 = Convert.ToInt32(Console.ReadLine());

double d =Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));

Console.WriteLine(d);

//Задача 23
//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Задача 23");
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int count =1;
if (N<count)
{
    Console.WriteLine("Введите положительное число");
}
while (N>=count)
{
    Console.Write(Math.Pow(count,3)+ "  ");
    count ++;
}
