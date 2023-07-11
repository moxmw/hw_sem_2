// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Например:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
string numberString = number.ToString();
if (numberString.Length >= 3)
{
    char thirdDigit = numberString[2];
    Console.WriteLine("Третья цифра числа: " + thirdDigit);
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}