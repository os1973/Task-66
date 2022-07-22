/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int[] InitArray(int M, int N);

void SumArray((M,N), sum)
{
    if(array == 0)
        Console.WriteLine(sum);
    else
    {
        sum = sum + (array % 10);
        SumArray(array/10, sum);
    }
}

Console.WriteLine("введите число M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("введите число N");
int N = int.Parse(Console.ReadLine());
int sum = 0;
SumArray((M,N) summ);

