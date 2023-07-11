// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Например:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.WriteLine("Введите цифру, обозначающую день недели (1-7):");
int dayNum = int.Parse(Console.ReadLine());
if (dayNum >= 1 && dayNum <= 7)
{
    if (dayNum == 6 || dayNum == 7)
    {
        Console.WriteLine("Это выходной день!");
    }
    else
    {
        Console.WriteLine("Это рабочий день.");
    }
}
else
{
    Console.WriteLine("Введено некорректное значение. Введите число от 1 до 7.");
}