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

Console.WriteLine("Поиск второго символа в числе");
int number = getNumber("Введите трехзначное число");
Console.WriteLine((number/10)%10);