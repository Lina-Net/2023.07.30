// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int a = 0;
int Akkerman(int m, int n)
{
    if (m == 0)  
    {
        a = n + 1;
    }
    if (n == 0 && m > 0)
    {
      a = Akkerman(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
      a = Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return a;
}


Console.Write("Введите  число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Akkerman(m,n)}");