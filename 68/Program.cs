// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите значение аргумента n: ");
uint n = uint.Parse(Console.ReadLine());
Console.Write("Введите значение аргумента m: ");
uint m = uint.Parse(Console.ReadLine());

Console.WriteLine(Ackermann(n, m));

static uint Ackermann(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
            return Ackermann(n - 1, 1);
        else
            return Ackermann(n - 1, Ackermann(n, m - 1));
}