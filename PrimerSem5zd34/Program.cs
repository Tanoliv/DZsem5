// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2



/*int[] massiv = NewMassiv(25, 700, 800);
Console.Write("massiv = [");
Console.Write(String.Join(", ", massiv));
Console.Write("]");
Console.WriteLine("");

int[] NewMassiv(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}


int result = 0;
for(int i =0; i < massiv.Length; i++)
{
      if(massiv[i] % 2 == 0)
    {
        result++;
    }
}

Console.Write($"Количество чётных элементов в массиве: {result}");*/

int[] massiv = NewMassiv(20, 700, 800);
Console.Write("massiv = [");
Console.Write(String.Join(", ", massiv));
Console.Write("]");
Console.WriteLine("");
Console.Write($"Количество чётных элементов в массиве: {Method()}");

int[] NewMassiv(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

int Method()
{
    int result = 0;
    for(int i =0; i < massiv.Length; i++)
    {
      if(massiv[i] % 2 == 0)
      {
           result++;
      }
    
}
        return result;
}   