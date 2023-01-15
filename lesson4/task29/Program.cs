
void getArr (string message)
{
    while (true)
    {
        Console.WriteLine(message);
        string text = Console.ReadLine();
        string[] textArr  = text.Split(',');   
        if (textArr.Length == 8)
        {
            Console.WriteLine("[{0}]", string.Join(", ", textArr));
            break;
        }
        else
        {
            Console.WriteLine("Необходимо ввести массив из 8 символов, а у вас из " + textArr.Length);
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}

getArr("Введите элеметны массива через запятую");