// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//Method
int GetSum(int min, int max)
{
    if (min > max) return 0;
    return (GetSum(min, max - 1) + max);
}


//Code
Console.WriteLine("Задайте меньшее целое число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте большее целое число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма натуральных элементов в промежутке от m до n:");
Console.Write(GetSum(m, n));