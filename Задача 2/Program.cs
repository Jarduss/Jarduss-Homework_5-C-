/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] CreateArray(int size, int minValue, int MaxValue)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, MaxValue);
    }
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ )
    {
    Console.Write(array[i] + " ");
    }
  Console.WriteLine();
}

int GetEven(int[] array)
{
    int even = 0;
    int sum =0;
    for (int i = 0; i < array.Length; i++)
    {
      if (i % 2 == 1)
      {
        sum = sum + array[i];
      }
    }
  return sum;
  }

int[] array  = CreateArray(10, 1, 5);
WriteArray(array);
Console.WriteLine();
int quantity = GetEven(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {quantity}");