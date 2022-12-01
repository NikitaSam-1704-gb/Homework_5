// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

using static System.Console;
Clear();

int [] FillArrayRamdom(int number, int minValues, int maxValues)
{
    int[] array= new int[number];
    for(int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(minValues,maxValues+1);
    }
    WriteLine(String.Join(" ", array));
    return array;
}

void SumPositiveNegativElements( int [] array)
{
    int sumPositive=0;
    int sumNegativ=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>=0)
            sumPositive=sumPositive+array[i];
        else
           sumNegativ+=array[i]; 
    }
    WriteLine($" Сумма положительных элементов {sumPositive}");
    WriteLine($" Сумма отрицательных элементов {sumNegativ}");
}

WriteLine(" Задан массив случайных чисел  [-9, 9] размером 12 ");
int[] massiv=FillArrayRamdom(12, -9, 9);
SumPositiveNegativElements(massiv);
