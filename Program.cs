//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9].
//Найтиде сумму отрицательных и положительных элементов массива.


/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];

    for( int i = 0; i < size; i ++)
         newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;     
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i] + " ");
        Console.WriteLine();
}

int FindSumPos(int[] array)
{
    int sumPos =0;
    for(int i = 0; i < array.Length; i++)
       if (array [i] > 0)
          sumPos += array [i];
    return sumPos;      
}
int FindSumNeg(int[] array)
{
    int sumNeg =0;
    for(int i = 0; i < array.Length; i++)
       if (array [i] < 0)
          sumNeg += array [i];
    return sumNeg;  
}

int size_array = 12;
int minValue_array = -9;
int maxValue_array =9;

int [] createdArray = CreateRandomArray(size_array, minValue_array, maxValue_array);
ShowArray(createdArray);
Console.WriteLine($" Summ of possitive elements is {FindSumPos(createdArray)}");
int resaltNeg = FindSumNeg(createdArray);
Console.WriteLine($" Summ of negative elements is {resaltNeg}");


//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

/*
void ShowArray (int[] array); // демонстрация массива

int [] FindMultiPar (int[] arrayCreatad)
{
    int size2;
    if(arrayCreatad.Length % 2 == 0 )
    size2 = arrayCreatad.Length / 2;               //длина массива с произведениями
    else size2 = (arrayCreatad.Length + 1) / 2;

    int [] arrayMulti = new int [size2]; 
    for(int i = 0; i < arrayCreatad.Length / 2; i++)
    {
            arrayMulti[i] = arrayCreatad[i]* arrayCreatad[arrayCreatad.Length -1 -i];

    // i                 012345
    // arr[size - 1 -i ] 456789
    // 0 5-> 1 6-1-1-2=3

     }
     if(arrayCreatad.Length %2 !=0)
      arrayMulti[size2 -1] = arrayCreatad[(arrayCreatad.Length +1)/2];
     return arrayMulti;
}

Console.WriteLine("Input size if array: ");
int array_size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible val if array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max possible val if array: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int [] array1 = CreateRandomArray (array_size, minValue, maxVal);

ShowArray (array1);

int [] array2 = FindMultiPar(array1);
ShowArray (array2);
*/
//Задайте массив из 123 чисел. Найдите количество элементов массива, значение которых 
//лежат в отрезке [10,99]
/*
int [] CreateRandomArray (int size, int minValue, int maxValue)  // метод создания массива с рандэлементами
{
    int [] newArray = new int [size];

    for (int i=0; i < size; i++)
         newArray[i] = new Random().Next(minValue,maxValue +1);
    return newArray;
}
void ShowArray (int[] array) //демонстрация массива
{
    for (int i = 0; i < array.Length; i++)
         Console.WriteLine(array[i]+" ");
    Console.WriteLine();
}


int Count1099(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
     if (array[i] > 9 && array[i] < 100)
         count++;
    return count;
}
Console.WriteLine("Input min possible val if array: ");
int minVal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max possible val if array: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int size_array =123;

int [] arrayCreated = CreateRandomArray(size_array, minVal, maxVal);
ShowArray(arrayCreated);
int res = Count1099(arrayCreated);
Console.WriteLine($"Count of elements between 10 and 99 is {res} ");

*/
// домашнее задание
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.

//[3 7 22 2 78] -> 76
/*
int [] CreateRandomArray (int size, int minValue, int maxValue) 
{
    int [] newArray = new int [size];
     
    for (int i=0; i < size; i++)
         newArray[i] = new Random().Next(minValue,maxValue +1);
    return newArray;
}
void ShowArray (int[] array) 
{
    for (int i = 0; i < array.Length; i++)
         Console.WriteLine(array[i]+" ");
    Console.WriteLine();
}
int Diferenc (int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
     if (array[i] > int.MinValue && array[i] < int.MaxValue)
         count++;
    return count;
}
Console.WriteLine("Input min possible val if array: ");
int minVal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max possible val if array: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int size_array = maxVal - minVal;

int [] arrayCreated = CreateRandomArray(size_array, minVal, maxVal);
ShowArray(arrayCreated);
int res = Random(arrayCreated);

int Random(int[] arrayCreated)
{
    throw new NotImplementedException();
}

Console.WriteLine($"Diferenc of elements between min and max is {res} ");
*/
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//345, 897, 568, 234] -> 2
/*


int [] CreateRandomArray (int size, int minValue, int maxValue) 
{
    int [] newArray = new int [size];

    for (int i=0; i < size; i++)
         newArray[i] = new Random().Next(minValue,maxValue +1);
    return newArray;
}
void ShowArray (int[] array) 
{
    for (int i = 0; i < array.Length; i++)
         Console.WriteLine(array[i]+" ");
    Console.WriteLine();
}


int Countnumber(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
     if (array[i] > 100 && array[i] < 999)
         count++;
    return count;
}
Console.WriteLine("Input trhee digit numbers : ");
int minVal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input trhee digit numbers: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int size_array = minVal/2; 

int [] arrayCreated = CreateRandomArray(size_array, minVal/2, maxVal/2);
ShowArray(arrayCreated);
int res = Countnumber(arrayCreated);
Console.WriteLine($"even of elements  is {res} ");
*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

/*
int [] CreatRandomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];

    for( int i = 0; i < size; i ++)
         newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;     
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i] + " ");
        Console.WriteLine();
}

int FindSum(int[] array)
{
    int sum =0;
    for(int i = 0; i < array.Length; i++)
       if (array [i] > 0)
          sum += array [i];
    return sum;      
}
int FindSum1(int[] array)
{
    int sum1 =1;
    for(int i = 1; i < array.Length; i++)
       if (array [i] < 0)
          sum1 += array [i];
    return sum1;  
}
Console.WriteLine("Задайте одномерный массив : ");
int minVal = Convert.ToInt32(Console.ReadLine());

int size_array = 3 ;
int minValue_array = 1;
int maxValue_array =99;

int [] createdArray = CreatRandomArray(size_array, minValue_array, maxValue_array);
ShowArray(createdArray);
Console.WriteLine($" Summ of elements in odd position is {FindSum(createdArray)}");
int resaltNeg = FindSum1 (createdArray);
Console.WriteLine($" Summ of  elements odd positionis {resaltNeg}");
*/
