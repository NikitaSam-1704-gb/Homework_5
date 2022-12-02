//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

using static System.Console;
Clear();

( int number, int minValue, int maxValues) ParametersRandomArray()
{
    (int number, int minValues, int maxValues) parameters;
    Write(" Введите размер вещественного массива  ");
    parameters.number=Convert.ToInt32(ReadLine());
    Write(" Введите минимальное Значение ");
    parameters.minValues=Convert.ToInt32(ReadLine());
    Write(" Введите максимальное Значение  ");
    parameters.maxValues=Convert.ToInt32(ReadLine());
    return parameters;
}

double [] FillArrayRamdom(int number, int minValues, int maxValues)
{
    double[] array=new double[number];
    for(int i=0; i<array.Length; i++)
        array[i]=new Random().NextDouble()* new Random().Next(minValues,maxValues+1);
        
    return array;
}

void PrintArray(double[] array)
{
    Write("Массив ");
    for(int i=0; i<array.Length; i++)
        Write($" {array[i]:f} "); 
        WriteLine();
}

double  MaximumDistance(double[] array)
{
    double minElement=array[0];
    double maxElement=array[0];
    double summ=-1;

    if(array.Length<2)
        return summ;

    for(int i=1; i<array.Length; i++)
    {
        if(array[i]<minElement)
            minElement=array[i];
        if(array[i]>=maxElement)
            maxElement=array[i];
    }
    summ=maxElement-minElement;
    return summ;
}

(int number, int minValues, int maxValues) parametersWork=ParametersRandomArray();
double[] massiv=FillArrayRamdom(parametersWork.number, parametersWork.minValues, parametersWork.maxValues);
PrintArray(massiv);
double sumWork=MaximumDistance(massiv);
if(sumWork==-1)
    WriteLine(" Ошибка, Количество элементов массива должно быть два и более");
else 
    WriteLine($" Максимальное расстояние между элементами -> {sumWork:f}");