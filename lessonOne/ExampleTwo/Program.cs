Console.WriteLine("Максимальное из трех чисел");
Console.WriteLine("Введите чисто A: ");
int numberA = int.Parse(Console.ReadLine()?? "Введено некоректное значение, необходимо ввести цифру");
Console.WriteLine("Введите чисто B: ");
int numberB = int.Parse(Console.ReadLine()?? "Введено некоректное значение, необходимо ввести цифру");
Console.WriteLine("Введите чисто С: ");
int numberC = int.Parse(Console.ReadLine()?? "Введено некоректное значение, необходимо ввести цифру");
if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine($"Максиамльное из трех - A: {numberA}");
}
else if (numberB > numberC)
{
    Console.WriteLine($"Максиамльное из трех - B: {numberB}");
}
else
{
    Console.WriteLine($"Максиамльное из трех - C: {numberC}");
}
