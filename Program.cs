/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNaturN(int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNaturN(n - 1);
}
ShowNaturN(5);

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                       
    else if (M < N) return N + SumNumbers(M, N - 1); 
    else return N + SumNumbers(M, N + 1);            
}

Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result, Sum = {SumNumbers(M, N)}");

Задаче 68: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную
*/
int Binar(int n)
{
    int res;
    if (n != 0)
    {
        res = (n % 2) + 10 * Binar(n / 2);
        Console.Write(res);
        return 0;
    }
    else return 0;
    
}
Binar(4);

