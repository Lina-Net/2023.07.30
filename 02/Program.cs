// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int sum = 0;

int Summa( int m, int n)
{   
    if (m<=n)
    {
        sum = Summa(m+1,n) + m;
    }
    return sum;
}

Console.Write("Введите  число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  число n, n > m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных чисел от М до N равна {Summa(m, n)}");