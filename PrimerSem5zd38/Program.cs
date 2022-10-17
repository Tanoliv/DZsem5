// Задача 38: Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности,
// с дробными не работаем). Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

/*int[] massiv = NewMassiv(10, -10, 10);
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

int minNum = massiv[0];
int maxNum = massiv[0];
int result = 0; 

for( int i = 0; i < massiv.Length; i++)
{
    
       
    if(massiv[i] < minNum) minNum =  massiv[i];       
     
    if(massiv[i] > maxNum) maxNum =  massiv[i];
           
    result = maxNum - minNum;
        
}
 Console.WriteLine($"минимальная позиция = {minNum}.");

Console.WriteLine($"максимальная позиция = {maxNum}.");

Console.WriteLine($"разница между max и min элементами массива = {result}.");*/

int[] massiv = NewMassiv(10, -10, 10);
Console.Write("massiv = [");
Console.Write(String.Join(", ", massiv));
Console.Write("]");
Console.WriteLine("");
Console.WriteLine($"разница между max и min элементами массива = {Method()}.");

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
int minNum = massiv[0];
int maxNum = massiv[0];
int result = 0; 

    for( int i = 0; i < massiv.Length; i++)
    {
    
       
        if(massiv[i] < minNum) minNum =  massiv[i];       
     
        if(massiv[i] > maxNum) maxNum =  massiv[i];
           
        result = maxNum - minNum;        
    }
                return result;
}

