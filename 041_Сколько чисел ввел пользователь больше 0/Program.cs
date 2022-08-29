// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Clear();

Console.Write("Сколько чисел вы будете вводить: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];

int count = 0;
for (int i = 0; i < size; i++)
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    numbers[i] = num;
    if (numbers[i] > 0) count++;
}

Console.Write(string.Join(" ", numbers));
Console.Write($" - введено чисел больше 0: {count}");
