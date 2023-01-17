/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int getNumber (string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введите корректные данные."); 
        }
    }
    return result;
}

int[] initArray (int number)
{
    int[] result = new int[number];
    Random rnd = new Random();
    for (int i = 0; i < number; i++)
    {
        result[i] = rnd.Next(0,100);
    }
    return result;
}

void PrintArray(int [] array)
{
foreach (int i in array)
{
    Console.Write($"{i} ");
}
    Console.WriteLine();
}

void DiffMinMax (int [] array)
{
    int minElement = array[0];
    int maxElement = array[0];
    foreach (int i in array)
    {
            if (i > maxElement)
                maxElement = i;
            if (i < minElement)
                minElement = i;
    }
    Console.WriteLine($"Разница между минимальным и максимальным элементом массива равняется {maxElement - minElement}");
}

int number = getNumber("Введите размер массива: ");
int[] arr = initArray(number);
PrintArray(arr);
DiffMinMax(arr);