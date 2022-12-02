/*// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
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
SumPositiveNegativElements(massiv);*/


 /*//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

using static System.Console;
Clear();

(int number, int minValues, int maxValues) ParametersRandomArray()
{
    (int number, int minValues, int maxValues) parameters;
    Write(" Введите размер массива  ");
    parameters.number=Convert.ToInt32(ReadLine());
    Write(" Введите минимальное Значение ");
    parameters.minValues=Convert.ToInt32(ReadLine());
    Write(" Введите максимальное Значение ");
    parameters.maxValues=Convert.ToInt32(ReadLine());
    return parameters;
}

int [] FillArrayRamdom(int number, int minValues, int maxValues)
{
    int[] array=new int[number];
    for(int i=0; i<array.Length; i++)
        array[i]=new Random().Next(minValues,maxValues+1);
    return array;
}

void PrintArray(int[] array)
{
  WriteLine(String.Join(" ", array));  
}


int[] ArrayMirrorElements( int [] array)
{
    int[] arrayMirror= new int[array.Length];
    for(int i=0; i<array.Length; i++)
        arrayMirror[i]=array[i]*(-1);
    return arrayMirror;
}

(int number, int minValues, int maxValues) parametersWork=ParametersRandomArray();
int[] massiv=FillArrayRamdom(parametersWork.number, parametersWork.minValues, parametersWork.maxValues);
PrintArray(massiv);
int[] massivMirror=ArrayMirrorElements(massiv);
PrintArray(massivMirror);*/

/*// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да


using static System.Console;
Clear();

(int number, int minValues, int maxValues) ParametersRandomArray()
{
    (int number, int minValues, int maxValues) parameters;
    Write(" Введите размер массива  ");
    parameters.number=Convert.ToInt32(ReadLine());
    Write(" Введите минимальное Значение ");
    parameters.minValues=Convert.ToInt32(ReadLine());
    Write(" Введите максимальное Значение ");
    parameters.maxValues=Convert.ToInt32(ReadLine());
    return parameters;
}

int [] FillArrayRamdom(int number, int minValues, int maxValues)
{
    int[] array=new int[number];
    for(int i=0; i<array.Length; i++)
        array[i]=new Random().Next(minValues,maxValues+1);
    return array;
}

void PrintArray(int[] array)
{
  WriteLine(String.Join(" ", array));  
}


void NumberSearch( int [] array, int number)
{
    bool flag=false;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]== number)
        {
            flag=true;
            break;
        }
    }
    if(flag==true)
        WriteLine(" -> да, данное число есть в массиве ");
    else
        WriteLine(" -> нет, данного числа нет в массиве ");    
}

(int number, int minValues, int maxValues) parametersWork=ParametersRandomArray();
int[] massiv=FillArrayRamdom(parametersWork.number, parametersWork.minValues, parametersWork.maxValues);
PrintArray(massiv);
Write(" Введите число поиск которого будет осуществляться в массиве ");
int chislo=Convert.ToInt32(ReadLine());
NumberSearch(massiv, chislo);*/

/*// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

using static System.Console;
Clear();

(int number, int minValues, int maxValues) ParametersRandomArray()
{
    (int number, int minValues, int maxValues) parameters;
    Write(" Введите размер массива  ");
    parameters.number=Convert.ToInt32(ReadLine());
    Write(" Введите минимальное Значение ");
    parameters.minValues=Convert.ToInt32(ReadLine());
    Write(" Введите максимальное Значение ");
    parameters.maxValues=Convert.ToInt32(ReadLine());
    return parameters;
}

int [] FillArrayRamdom(int number, int minValues, int maxValues)
{
    int[] array=new int[number];
    for(int i=0; i<array.Length; i++)
        array[i]=new Random().Next(minValues,maxValues+1);
    return array;
}

void PrintArray(int[] array)
{
  WriteLine(String.Join(" ", array));  
}


int CountElementsInterval( int [] array, int minValues, int maxValues)
{
    int count=0;
    for(int i=0; i<array.Length; i++)
    {
        if(minValues<=array[i] && array[i]<=maxValues)
            count++;
    }
    return count;   
}

//(int number, int minValues, int maxValues) parametersWork=ParametersRandomArray();

int[] massiv=FillArrayRamdom(123, 0, 123);
PrintArray(massiv);
//Write(" Введите число поиск которого будет осуществляться в массиве ");
int chislo=CountElementsInterval(massiv, 10, 99);
WriteLine($" Число элементов массива в интервале [10,99] равно {chislo}");*/


/*//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

using static System.Console;
Clear();

(int number, int minValues, int maxValues) ParametersRandomArray()
{
    (int number, int minValues, int maxValues) parameters;
    Write(" Введите размер массива  ");
    parameters.number=Convert.ToInt32(ReadLine());
    Write(" Введите минимальное Значение ");
    parameters.minValues=Convert.ToInt32(ReadLine());
    Write(" Введите максимальное Значение ");
    parameters.maxValues=Convert.ToInt32(ReadLine());
    return parameters;
}

int [] FillArrayRamdom(int number, int minValues, int maxValues)
{
    int[] array=new int[number];
    for(int i=0; i<array.Length; i++)
        array[i]=new Random().Next(minValues,maxValues+1);
    return array;
}

void PrintArray(int[] array)
{
  WriteLine(String.Join(" ", array));  
}

int [] task37(int[] array)
{
    int size;
    if(array.Length%2==0)
         size=(array.Length/2);
    else
        size=(array.Length/2+1);
    int [] sumArray= new int[size];
    
    for(int i=0; i<size; i++)
    {
        if(i!=array.Length-1-i)
            sumArray[i]=array[i]*array[array.Length-1-i];
        else
            sumArray[i]=array[i]; 
    }
    return sumArray;
}

(int number, int minValues, int maxValues) parametersWork=ParametersRandomArray();
int[] massiv=FillArrayRamdom(parametersWork.number, parametersWork.minValues, parametersWork.maxValues);
PrintArray(massiv);
int[] sumMassiv=task37(massiv);
PrintArray(sumMassiv);*/


///Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using static System.Console;
Clear();

(int number, int minValues, int maxValues) ParametersRandomArray()
{
    (int number, int minValues, int maxValues) parameters;
    Write(" Введите размер массива  ");
    parameters.number=Convert.ToInt32(ReadLine());
    Write(" Введите минимальное Значение ");
    parameters.minValues=Convert.ToInt32(ReadLine());
    Write(" Введите максимальное Значение ");
    parameters.maxValues=Convert.ToInt32(ReadLine());
    return parameters;
}

int [] FillArrayRamdom(int number, int minValues, int maxValues)
{
    int[] array=new int[number];
    for(int i=0; i<array.Length; i++)
        array[i]=new Random().Next(minValues,maxValues+1);
    return array;
}

void PrintArray(int[] array)
{
  WriteLine(String.Join(" ", array));  
}

void  CountEvenElements(int[] array)
{
    int count=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]%2==0)
            count++;
    }
    WriteLine($" Количество элементов имеющих четное значение -> {count}");
}

(int number, int minValues, int maxValues) parametersWork=ParametersRandomArray();
int[] massiv=FillArrayRamdom(parametersWork.number, parametersWork.minValues, parametersWork.maxValues);
PrintArray(massiv);
CountEvenElements(massiv);