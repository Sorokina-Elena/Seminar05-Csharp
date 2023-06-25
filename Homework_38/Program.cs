/*
Задача 38
Задайте массив, используя класс Random () вещественных чисел. 
Найдите разницу между максимальной и минимальной вещественной частью элементов массива*/

double[] CreateArray(int size, int min, int max){ 
double[] myArray = new double [size];
Random randNum = new Random();

for (int i = 0; i < size; i++) 
    { 
        myArray [i] = randNum.Next(min, max) + randNum.NextDouble();
    } 
    Console.WriteLine($"[{string.Join(", ", myArray)}]"); 
    return myArray;
}

double FindMaxPart(double [] array)
{
    double MaxPart = array[0]%1;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i]%1 > MaxPart)
        {
            MaxPart = array[i]%1;
        }
    }
    return MaxPart;
}

double FindMinPart(double [] array)
{
    double MinPart = array[0]%1;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i]%1 < MinPart)
        {
            MinPart = array[i]%1;
        }
    }
    return MinPart;
}

double [] arr = CreateArray(5,0,10);
double resultMax = FindMaxPart(arr);
double resultMin = FindMinPart(arr);
double finishResult =(resultMax - resultMin);
Console.WriteLine($"Максимальная вещественная часть из чисел массива равна {resultMax}");
Console.WriteLine($"Минимальная вещественная часть из чисел массива равна {resultMin}");
Console.WriteLine($"Разница между максимальной и минимальной вещественной частью чисел массива равна {finishResult}");
