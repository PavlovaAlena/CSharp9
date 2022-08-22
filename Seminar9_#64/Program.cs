// Задача 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

//***********************
bool InputDannyh(string text, out int val1)
{
    val1 = 0;
    Console.Write($"{text} : ");
    bool KrivoyVvod = false;
    if (!int.TryParse(Console.ReadLine(), out int itemp))
    { KrivoyVvod = true; }
    if (Convert.ToInt32(itemp) < 2)
    { KrivoyVvod = true; }
    if (KrivoyVvod)
    {
        Console.WriteLine("Вводимые данные должны быть числовыми и больше 1!!!");
        Console.Write("Хотите повторно ввести данные? (y - да): ");
        string otvet = Console.ReadLine();
        if (otvet == "y" || otvet == "Y")
        { return InputDannyh(text, out val1); }

        return false;
    }

    val1 = Convert.ToInt32(itemp);
    return true;
}

//************************
void PrintNumber(int n)
{
    if (n < 1)
    {return;}
    Console.Write(n + " ");
    PrintNumber(n-1); 
}

//***********************
Console.Clear();
Console.Write("Программа задает значение N и выводит все натуральные числа в промежутке от N до 1.");
Console.WriteLine("");

int n;

if (!InputDannyh("Введите значения N", out n))
{ Console.WriteLine("Расчет прерван из-за отказа ввода данных"); }
else
{
    Console.WriteLine("Ряд натуральных чисел: ");
    PrintNumber(n);
    Console.WriteLine("");
}
