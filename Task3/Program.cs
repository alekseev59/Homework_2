// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели");
int num = int.Parse(Console.ReadLine());

if ((num >= 1) && (num < 6))
{
    Console.WriteLine("Не является выходным");
}
if ((num >= 6) && (num < 8))
{
    Console.WriteLine("Ура, выходной!");
}
if (num >= 8)
{
    Console.WriteLine("В неделе 7 дней:)");
}
if (num < 1)
{
    Console.WriteLine("В неделе 7 дней:)");
}