/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int[,] sortRow(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - j - 1; k++)
            {
                if (arr[i,k] > arr[i,k+1])
                {
                    int temp = arr[i,k]; 
                    arr[i,k] = arr[i,k+1]; 
                    arr[i,k+1] = temp;
                }
            }            
        }      
    }
    return arr;
}
Console.WriteLine("Сортировка массива методом пузырька");
Console.WriteLine();
Console.WriteLine("Задайте размер массива");
Console.WriteLine();
int row = getNumber("Введите количество строк");
int coll = getNumber("Введите количество колонок");
int [,] matrix = initMatrix(row, coll);
printArray(matrix);
int [,] newMatrix = sortRow(matrix);
Console.WriteLine();
printArray(newMatrix);