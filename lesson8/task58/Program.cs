/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] initMatrix ()
{
    int[,] newArr = new int[2,2];
    Random rnd = new Random();
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            newArr[i,j] = rnd.Next(0,5);
        }
    }
    return newArr;
}

void printArray(int[,] printArr)
{
    for (int i = 0; i < printArr.GetLength(0); i++)
    {
        for (int j = 0; j < printArr.GetLength(1); j++)
        {
            Console.Write($"{printArr[i,j]} ");
        }
    Console.WriteLine();
    }
}

int[,] multMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] result = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            result[i,j] = 0;
            for (int k = 0; k < matrixOne.GetLength(0); k++)
            {
                result[i,j] += matrixOne[i, k] * matrixTwo[k,j];   
            }           
        }
    }
    return result;
}

int[,]arrOne = initMatrix();
printArray(arrOne);
Console.WriteLine();
int[,]arrTwo = initMatrix();
printArray(arrTwo);
Console.WriteLine();
int[,]arrResult = multMatrix(arrOne, arrTwo);
printArray(arrResult);