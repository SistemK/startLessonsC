void checkPalindrome (string message)
{
    int check = 0;
    Console.WriteLine(message);
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out check))
        {
            string strCheck = $"{check}";
            int count = strCheck.Length - 1;
            int result = 0;
            for (int i = 0; i < count / 2; i++)
            {   
                if (strCheck[i] == strCheck[count -i])
                {
                    result = 1;
                }
                else
                {
                    result = 0;
                    break;
                }
            }
            if (result == 1)
            {
                Console.WriteLine("Число палиндром");
                break;
            }
            else
            {
                Console.WriteLine("Число не палиндром");
                break;
            }

        }
        else 
        {
            Console.WriteLine("Необходимо ввести цифру!");
            Console.WriteLine("------------------------");
        }
    }
}

checkPalindrome("Введите число для проверки является ли оно числом палиндромом");