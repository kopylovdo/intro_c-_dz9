// Программа вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

//метод вычисления функции Аккермана
int Calculate_Ackerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Calculate_Ackerman(n - 1, 1);
    else
      return Calculate_Ackerman(n - 1, Calculate_Ackerman(n, m - 1));
}
int m = -1;
int n = -1;

while ((m < 0) || (n < 0))
{
    System.Console.WriteLine("Необходимо вводить неотрицательные числа");
    System.Console.Write("Введите значение числа m = ");
    m = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
    System.Console.Write("Введите значение числа n = ");
    n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
}

System.Console.WriteLine($"Вы ввели следующие значения: m = {m}, n = {n}");

int ackerman_function = Calculate_Ackerman(n,m);
System.Console.WriteLine($"Значение функции Аккермана для m = {m} и n = {n} - {ackerman_function}");