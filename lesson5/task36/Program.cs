/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
        result[i] = rnd.Next(-100,100);
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

void sumOddElements(int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
            sum = sum + array[i];
    }
    Console.WriteLine($"Сумма элементов массива на нечетных позициях равна {sum}");
}

int number = getNumber("Введите размер массива: ");
int[] arr = initArray(number);
PrintArray(arr);
sumOddElements(arr);