// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

//Method
string GetRange(int min, int max)
{
    string s = string.Empty;
    if (min > max) return s;
    return (GetRange(min, max - 1) + max);
}


//Code
Console.WriteLine("Задайте меньшее целое число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте большее целое число n");
int n = int.Parse(Console.ReadLine());
Console.Write(GetRange(m, n));