//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
        result[i] = rnd.Next(100, 999);
    }
    return result;
}

void PrintArray(int [] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
    Console.WriteLine();
}

void sumEvenNumbers(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum++;
        }
    }
    Console.WriteLine($"Количесво четных чисел в массиве равно {sum}");
}

int number = getNumber("Введите размер массива: ");
int[] arr = initArray(number);
PrintArray(arr);
sumEvenNumbers(arr);