// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите нижнее значение диапазона: ");
int lowNum = int.Parse(Console.ReadLine());
Console.Write("Введите верхнее значение диапазона: ");
int highNum = int.Parse(Console.ReadLine());

Console.Write($"M = {lowNum}; N = {highNum} -> {GetSumSequence(lowNum, highNum)}");

int GetSumSequence(int startNum, int endNum)
{
    if (endNum == startNum) return startNum;
    else 
    {
        int result = endNum + GetSumSequence(startNum, endNum - 1);
        return result;
    }
}

