// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M, N;

Console.WriteLine($"Введите число M: ");
int.TryParse(Console.ReadLine()!, out M);

Console.WriteLine($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);

Console.WriteLine($"{Sum(M, N)}");

int Sum(int left, int right)
{
    if (left >= right)
        return left;
    return left + Sum(left + 1, right);
}