// 66. Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.

Console.WriteLine ("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());


void GapNumberSum (int M, int N, int sum)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (M++);
    GapNumberSum(M, N, sum);
}
GapNumberSum (M, N, 0);
