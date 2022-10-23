/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

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
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 ==0)
        { 
            even++;
        }
    }
    return even;
}
int[] array  = CreateArray(11, 100, 1000);
WriteArray(array);
Console.WriteLine();
int quantity = GetEven(array);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");







