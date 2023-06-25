/*
Задача 34
Задайте массив, заполненый случайнвми трехзначными положительными числами.
Напишите программу котороая покажет кол-во четных чисел в массиве
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
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count+=1;  
        }
        
    }
    Console.WriteLine(count);
}


int [] arr = CreateArray(3,100,1000); 
FindSum(arr);