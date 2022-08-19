// Задача  68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//***********************
bool InputDannyh(string text, out int val1, out int val2)
{
    val1 = 0;
    val2 = 0;
    Console.Write($"{text} через пробел: ");
    int[] array = Console.ReadLine().Split(' ', 2, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    if (array.Length < 2 || array[0] < 0 || array[1] < 0)
    {
        Console.WriteLine("Вводимые данные должны состоять из 2х положительных чисел, разделенных пробелом!!!");
        Console.Write("Хотите повторно ввести данные? (y - да): ");
        string otvet = Console.ReadLine();
        if (otvet == "y" || otvet == "Y")
        { return InputDannyh(text, out val1, out val2); }

        return false;
    }
    val1 = array[0];
    val2 = array[1];
    return true;
}

//************************
int FumcAkkNumber(int m, int n)
{
    if (m == 0)
    { return n + 1; }
    else if (n == 0)
    { return FumcAkkNumber(m - 1, 1); }
    else
    { return FumcAkkNumber(m - 1, FumcAkkNumber(m, n - 1)); }
}

//***********************
Console.Clear();
Console.Write("Программа задает неотрицаиельные значения M и N и вычисляет функции Аккермана с помощью рекурсии.");
Console.WriteLine("");

int m, n;

if (!InputDannyh("Введите положительные значения M и N", out m, out n))
{ Console.WriteLine("Расчет прерван из-за отказа ввода данных"); }
else
{
    int count = m;
    int FA = FumcAkkNumber(m, n);
    Console.WriteLine("Функция Аккермана A(m,n) = " + FA);
}
