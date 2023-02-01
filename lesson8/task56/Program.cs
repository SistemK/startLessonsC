/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int getNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result)) break;
        else Console.WriteLine("Введены не корректные данные.");
    }
    
    return result;
}

int [,] initMatrix(int row, int coll)
{
    Random rnd = new Random();
    int[,] arr = new int[row,coll];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(0,10);
        }       
    }
    return arr;
}

void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        } 
    Console.WriteLine();      
    }
}

int minElementArray(int[] arr)
{
    int min = arr[0];
    int numberRow = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= min)
        {  
            numberRow = i+1;
        }
    }
    return numberRow;
}

void minSumRow(int[,] arr)
{
    int[] sumArray = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {            
            sumRow += arr[i,j];       
        } 
        sumArray[i] = sumRow;    
    }
    int minRow = minElementArray(sumArray);
    Console.WriteLine($"Минимальная сумма элементов строки массива = {sumArray[minRow-1]}, cтрока номер {minRow}");
}

Console.WriteLine("Нахождение строки массива с наименьшей суммой элементов");
Console.WriteLine();
Console.WriteLine("Задайте размер массива");
Console.WriteLine();
int row = getNumber("Введите количество строк");
int coll = getNumber("Введите количество колонок");
int [,] matrix = initMatrix(row, coll);
printArray(matrix);
Console.WriteLine();
minSumRow(matrix);