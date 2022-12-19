Console.WriteLine("Вывод всех четных чисел от 1 до N");
Console.WriteLine("Введите число N: ");
int numberN = int.Parse(Console.ReadLine() ?? "Введено некоректное значение, необходимо ввести цифру");
int counter = 1;
while (counter <= numberN)
{
    if (counter % 2 == 0)
    {
        Console.WriteLine($"{counter}");
    }
    counter ++;
}