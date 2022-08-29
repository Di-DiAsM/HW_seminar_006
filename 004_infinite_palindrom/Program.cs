// задание дал проверяющий, но я пропустил много, сейчас сделал и догоняю по доп заданиям
//4й способ**************************************************************** 
// задача по определению полиндрома:
// a) рассматривая ввод как число а не как строку)
// б) для числа произвольной длины)
//*************************************************************************
// Логика такая перевернуть число, если перевернутое число равно исходному, то число ПАЛИНДРОМ

Console.Clear();

Console.WriteLine("Введите любое число больше 100: ");
long num = Convert.ToInt64(Console.ReadLine());  // пришлось поменять... ToInt32 слишком маленькие числа, не хватало памяти

long inverseNum = 0;
long reminder = 0;
long originalNum = num;
while(num > 0)
{
    reminder = num % 10;
    num = num / 10;
    inverseNum = inverseNum * 10 + reminder; 
}
Console.WriteLine(inverseNum);

if(inverseNum == originalNum)
{
    Console.WriteLine($"Число {originalNum} является палиндромом");
}
else
{
    Console.WriteLine($"Число {originalNum} не является палиндромом");
}
