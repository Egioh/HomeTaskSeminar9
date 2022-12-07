
// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m =1;
int n=15;
int summ=0;
void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Final summ {summ} ");
    return;
  }
  Console.WriteLine (summ);
  PrintSumm(m, n - 1, summ);
}
PrintSumm (m,n,summ);