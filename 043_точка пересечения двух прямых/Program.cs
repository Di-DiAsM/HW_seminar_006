// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y =  a * x + c
// y = k1 * x + b1  **

// y =  b * x + d
// y = k2 * x + b2  **

// x = (d - c) / a - b
// x = b2 - b1 / k1 - k2  **

// y = a * (d - c / a - b) + c
// y = k1 * x + c **

// if a == b - две прямые параллельны
//   k1 == k2  **
// с  != d - пряме различны и не имеют пересений, в протовном случае прямые совпадают
// b1 != b2 ** 

Console.Clear();

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("для первого уравнения y1 = k1 * x + b1");
double b1 = ReadInt("введите b1: ");
double k1 = ReadInt("введите k1: ");


Console.WriteLine("для второго уравнения y2 = k2 * x + b2");
double b2 = ReadInt("введите b2: ");
double k2 = ReadInt("введите k2: ");

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые сопадают и имеют бесконечное количество общих точек");
}
else if (k1 == k2)
{
    Console.WriteLine("Две прямые параллельны");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
}

