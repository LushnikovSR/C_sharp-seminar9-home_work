// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Введите начальное число для декремента: ");
int num = int.Parse(Console.ReadLine());
Console.Write($"N = {num} -> '{GetSequenceDecrimentNum(num)}'");

string GetSequenceDecrimentNum(int baseNumber)
{
    if (baseNumber == 1) return baseNumber.ToString();
    else 
    {
        string result = baseNumber + ", " + GetSequenceDecrimentNum(baseNumber - 1);
        return result;
    }
}