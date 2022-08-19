// Задача 64. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

//***********************
bool InputDannyh(string text, out int val1, out int val2)
{
    val1 = 0;
    val2 = 0;
    Console.Write($"{text} через пробел: ");
    int[] array = Console.ReadLine().Split(' ', 2, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    if (array.Length < 2)
    {
        Console.WriteLine("Вводимые данные должны состоять из 2х чисел, разделенных пробелом!!!");
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
void PrintNumber(int m, int n, int count)
{
    Console.Write(count + " ");
    count++;
    if (count <= n)
    { PrintNumber(m, n, count); }
}

//***********************
Console.Clear();
Console.Write("Программа задает значения M и N и выводит все натуральные числа в промежутке от M до N.");
Console.WriteLine("");

int m, n;

if (!InputDannyh("Введите значения M и N", out m, out n))
{ Console.WriteLine("Расчет прерван из-за отказа ввода данных"); }
else
{
    int count = m;
    Console.WriteLine("Ряд натуральных чисел: ");
    PrintNumber(m, n, count);
    Console.WriteLine("");
}
