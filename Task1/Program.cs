// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int n = 10;
void Count (int N)
{
if (N>0)
    {
        Console.Write ($"{N} ");
        Count (N-1);
    }   
}    
Count(n);