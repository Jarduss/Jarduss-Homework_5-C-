/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] array = new double[10];
  for (int i = 0; i < array.Length; i++ )
  {
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
  }

double maxNum = array[0];
double minNum = array[0];

  for (int i = 1; i < array.Length; i++)
  {
    if (maxNum < array[i])
    {
      maxNum = array[i];
    }
        if (minNum > array[i])
    {
      minNum = array[i];
    }
  }

  double decision = maxNum - minNum;
  Console.WriteLine($"\nразница между между максимальным ({maxNum}) и минимальным({minNum}) элементами: {decision}");