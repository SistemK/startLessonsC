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

int degree (int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

Console.WriteLine("Возведение числа A в натуральную степень B");
int numberA = getNumber("Введите число A: ");
int numberB = getNumber("Введите число B: ");
int degreeAB = degree(numberA, numberB);
Console.WriteLine("Число " + numberA + " в степени " + numberB + " равняется " + degreeAB);