//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

ShowSum(m, n, temp=0);

void ShowSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов от m до n = {sum} ");
    return;
  }
  ShowSum(m, n - 1, sum);
}


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Console.WriteLine("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());
//  int rec(int n, int m)
//        {
//            if (n == 0)
//                return (m + 1);
//            if (m == 0 && n!=0)
//                return rec(n - 1, 1);
//            return rec(n - 1, rec(n, m - 1));
//        }
//      Console.WriteLine(rec(n,m));
