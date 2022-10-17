// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] massiv = NewMassiv(10, -100, 100);
Console.Write("massiv = [");
Console.Write(String.Join(", ", massiv));
Console.Write("]");
Console.WriteLine("");
Console.Write($"Сумма нечётных элементов = {Method1()}.");


int[] NewMassiv(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

 int Method1()
 {
    int sumnech = 0;

    for(int i = 0; i < massiv.Length; i++)
    {
        if(massiv[i] % 2 != 0)
        {
            sumnech = sumnech + massiv[i];
        }
    
    }
        return sumnech;
 }
