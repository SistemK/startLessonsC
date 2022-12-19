int checkWeekDays (string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 8)
        {
            if (result > 5)
            {
                Console.WriteLine("Выходной день");
                break;
            }
            else 
            {
                Console.WriteLine("Будний день");
                break;
            }
        }
        else
        {
            Console.WriteLine("Необходимо выбрать цифру от 1 до 7"); 
            Console.WriteLine("----------------------------------"); 
        }
    }
    return result;
}

Console.WriteLine("Проверка является ли цифры дня недели выходным.");
int number = checkWeekDays("Введите день недели");