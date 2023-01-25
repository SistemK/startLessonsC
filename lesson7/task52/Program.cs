/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int getNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введите корректное значение");
        }
    }
    return result;
}

int [,]  initArray (int row, int col)
{
    int[,] newArray = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            newArray[i,j] = rnd.Next(0,10);
        }
    }
    return newArray;
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

void average(int[,] arr)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i,j];
        }
        Console.Write($"{Math.Round((double)sum/arr.GetLength(1), 1)} ");
        sum = 0;
    }
}

Console.WriteLine("Ввывод среднего значения элементов каждого столбца");
int col = getNumber("Введите количество колонок массива");
int row = getNumber("Введите количество строк массива");
int[,] finishArray = initArray(col,row);
printArray(finishArray);
average(finishArray);