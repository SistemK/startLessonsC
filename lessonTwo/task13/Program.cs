int getNumber (string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))        
        {
            string strResult = $"{result}";
            if (strResult.Length != 3)
            {
                Console.WriteLine("Необходимо ввести трехзначное число");
                Console.WriteLine("-----------------------------------");
            }
            else 
            {
                break;
            }
        }
        else
        {
            Console.WriteLine("Введите корректные данные.");
            Console.WriteLine("-------------------------.");
        }
    }
    return result;
}

Console.WriteLine("Поиск второго символа в числе");
int number = getNumber("Введите трехзначное число");
Console.WriteLine(number%10);