// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Write("Введите начальное значение для диапазона случайных чисел: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение для диапазона случайных чисел: ");
int b = Convert.ToInt32(Console.ReadLine());

void InputArray(int [] array)
{

    for (int i = 0; i < 8; i++)
        array[i] = new Random().Next(a, b + 1);

}

int [] array = new int[8];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");