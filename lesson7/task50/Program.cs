/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
            newArray[i,j] = rnd.Next(-10,10);
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

void checkPosition(int number, int[,] checkArray)
{
    int col = number / 10;
    int row = number % 10;
    if (row < checkArray.GetLength(0) && col < checkArray.GetLength(1))
    {
        Console.WriteLine($"На данной позии находится число {checkArray[row,col]}");
    }
    else 
    {
        Console.WriteLine($"Индекса [{col},{row}] нет в массиве");
    }   
}

int col = getNumber("Введите количество колонок массива");
int row = getNumber("Введите количество строк массива");
int[,] finishArray = initArray(col,row);
printArray(finishArray);
int checkNumber = getNumber("Введите позицию элемента, который хотите отобразить в формате 14, где 1 - строка, 4 - колонка");
checkPosition(checkNumber, finishArray);