// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int a = new Random().Next (1, 11);
//int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a);
int b = new Random().Next (1, 11);
//int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(b);

int Stepen(int a, int b)
{
  int S = 1;
  for (int i = 0; i < b; i++)  
  {
    S = S * a;
  }
  return S;
}

Console.WriteLine(Stepen(a, b));
