// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void ShowNumbers (int numberN)
{
    Console.Write(numberN + " ");
   
    if (numberN > 1)
         ShowNumbers(numberN - 1);
}


Console.Write("Введите  число n: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n);