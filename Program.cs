//Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

//массив с пользовательским вводом (универсальный) double
double[] CreateArrayRndDouble(int size, int min, int max, int round = 2)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, round);
    }
       
    return arr;
}

//вывод на экран double (универсальный)
void PrintArrayDouble(double[] arr, string sep = ".")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write ($"{arr[i]}{sep} ");
        else Console.Write ($"{arr[i]}");
    }
}



//максимальный элемент
double MaxElementArray(double[] arr)
{
    double max=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]>max) max=arr[i];
    }
    return max;
}

//минимальный элемент
double MinElementArray(double[] arr)
{
    double min=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]<min) min=arr[i];
    }
    return min;
}

//разница
void DiffElementArray(double[] arr)
{
    double diff=Math.Round(MaxElementArray(arr)-MinElementArray(arr),2);
    Console.Write($" => {MaxElementArray(arr)} - {MinElementArray(arr)} = {diff}");
}

double[] array = CreateArrayRndDouble(5, 1, 99);
Console.Write("[");
PrintArrayDouble(array, ";");
Console.Write("]");

DiffElementArray(array);
