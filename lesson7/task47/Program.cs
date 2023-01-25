/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int getNumber(string message)
{    
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(),out result))
        {
            break;
        }        
        else
        {
            Console.WriteLine("Введите корректные данные");
        }
    }
    return result;
}


int[,] initArray(int row, int col)
{
    int[,] newArray = new int[col, row];
    Random rnd = new Random();
    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row; j++)
        {
            newArray[i,j] = rnd.Next(-10,10);
        }
    }
    return newArray;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
}

Console.WriteLine("Генерация двумерного массива со случайными числами");
int col = getNumber("Введите количество столбцов массива");
int row = getNumber("Введите количетсов строк массива");
int[,] finishArray = initArray(col,row);
printArray(finishArray);