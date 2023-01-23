
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
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

void findCross(float b1, float k1, float b2, float k2)
{
    float x = 0;
    float y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения заданных прямых - ({x}, {y}).");
}

Console.WriteLine("Нахождение точки пересечения двух прямых");
float b1 = getNumber("Задайте координату b1 первой прямой ");
float k1 = getNumber("Задайте координату k1 первой прямой ");
float b2 = getNumber("Задайте координату b2 первой прямой ");
float k2 = getNumber("Задайте координату k2 первой прямой ");
findCross(b1, k1, b2, k2);