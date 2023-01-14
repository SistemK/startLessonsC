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

int getSumV1 (int number)
{
    int result = 0;
    int count = number.ToString().Length;
    string arr = $"{number}";
    for (int i = 0; i < count; i++)
    {
       result += (int)Char.GetNumericValue(arr[i]);
       // result += arr[i] - '0'; - второй вариант, https://www.techiedelight.com/convert-char-to-int-csharp/
    }
    return result;
}

int getSumV2 (int number)
{
    int result = 0;
    while (number != 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

Console.WriteLine("Сумма цифр в числе");
int number = getNumber("Введите число");
int sum = getSumV1(number);
Console.WriteLine("Вариант нахождени суммы с помощью массива: " );
Console.WriteLine("Сумма цифр числа " + number + " равна " + sum );
Console.WriteLine("--------------------------------------------" );
sum = getSumV2(number);
Console.WriteLine("Вариант нахождени суммы с помощью мат. функций: " );
Console.WriteLine("Сумма цифр числа " + number + " равна " + sum );
Console.WriteLine("--------------------------------------------" );