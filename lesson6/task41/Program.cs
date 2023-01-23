
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

void getArr (string message)
{
    while (true)
    {
        Console.WriteLine(message);
        int sum = 0;
        string text = Console.ReadLine() ?? "NULL";
        int[] textArr  = text.Split(',').Select(Int32.Parse).ToArray();;   
        for (int i = 0; i < textArr.Length; i++)
        {
            if (textArr[i] > 0)
            {
                sum++;
            }
        }
        Console.WriteLine($"Вы ввели {sum} чисел больше нуля");
        break;
    }
}

Console.WriteLine ("Вычисление количества введеных чисел больше нуля");
getArr("Введите числа через запятую: ");