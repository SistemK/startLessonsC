/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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

int checkUniq(int[,,] matrix)
{
    Random rnd = new Random();
    int[] uniqArr = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];   
    while (true)
    {
        int number = rnd.Next(10,99);
        if (!uniqArr.Contains(number))
        {
            uniqArr.Append(number);
            return number;
        }  
    } 
}

int[,,] initMatrix (int x, int y, int z)
{
    int[,,] matrix = new int[x,y,z];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
               //matrix[,y,z] = 1; 
               matrix[i,j,k] = checkUniq(matrix);
            }
        }
    }
    return matrix;
}

void printArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]}({i},{j},{k}) ");                
            }
        } 
    Console.WriteLine();      
    }
}

Console.WriteLine("Нахождение строки массива с наименьшей суммой элементов");
Console.WriteLine();
Console.WriteLine("Задайте размер массива");
Console.WriteLine();
int x = getNumber("Введите высоту массива");
int y = getNumber("Введите ширину массива");
int z = getNumber("Введите глубину массива");
int[,,] newMatrix = initMatrix(x,y,z);
printArray(newMatrix);