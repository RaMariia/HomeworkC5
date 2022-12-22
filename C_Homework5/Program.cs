// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*
int[] CreateRandomArray(int size, int minValue, int maxValue) //МЕТОД, ФОРМИРУЮЩИЙ СЛУЧАЙНЫЙ МАССИВ

{
int[] array = new int[size];
for (int i = 0; i < size; i ++)
array[i] = new Random().Next(minValue = 100, maxValue = 999);  
return array;//просто имя массива
}

void ShowArray(int[] array) //МЕТОД, ОРГАНИЗУЮЩИЙ ВЫВОД МАССИВА
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int SumOfEvenNumbers(int[]array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
     if (array[i] % 2 == 0)
     {
        count ++;
     }   
    }
    return count;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, 100, 999);
ShowArray(myArray);

int result = SumOfEvenNumbers(myArray);
Console.WriteLine("Количество четных чисел в массиве: " + result);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(нечетные индексы).
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray(int size, int minValue, int maxValue) //МЕТОД, ФОРМИРУЮЩИЙ СЛУЧАЙНЫЙ МАССИВ

{
int[] array = new int[size];
for (int i = 0; i < size; i ++)
array[i] = new Random().Next(minValue, maxValue + 1);  
return array;//просто имя массива
}

void ShowArray(int[] array) //МЕТОД, ОРГАНИЗУЮЩИЙ ВЫВОД МАССИВА
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int SumOfElementsWithOddIndex(int[]array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
     if(i%2 == 1)
     {
        sum = sum + array[i];
     }   
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int result = SumOfElementsWithOddIndex(myArray);
Console.WriteLine("Сумма элементов, имеющих нечетный индекс: " + result);
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
void CreateRandomArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(0,1000)) / 100;
        }
}
void ShowArray(double[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
CreateRandomArray(array);
Console.WriteLine("Массив из {size} чисел: ");
ShowArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

Console.WriteLine($"Max : {max}, Min : {min}");
Console.WriteLine($"Max-min : {max - min}");
*/