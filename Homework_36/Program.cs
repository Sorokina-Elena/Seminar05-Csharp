/*
Задача 36
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечетных позициях
*/

int[] CreateArray(int size, int min, int max){ 
int[] myArray = new int [size];
Random randNum = new Random();

for (int i = 0; i < size; i++) 
    { 
        myArray [i] = randNum.Next(min, max);
    } 
    Console.WriteLine($"[{string.Join(", ", myArray)}]"); 
    return myArray;
}

void FindSum(int [] array)
{
    int sumNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 == 1)
        {
            sumNumber = sumNumber + array[i];
        }
        
    }
    Console.WriteLine(sumNumber);
}


int [] arr = CreateArray(8,0,10); 
FindSum(arr);
