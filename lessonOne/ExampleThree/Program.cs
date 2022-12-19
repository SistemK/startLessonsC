Console.WriteLine("Проверка четное ли число");
Console.WriteLine("Введите чисто: ");
int numberA = int.Parse(Console.ReadLine()?? "Введено некоректное значение, необходимо ввести цифру");
if ( numberA % 2 == 0)
{
    Console.WriteLine($"Число четное: {numberA}");
}
else 
{
    Console.WriteLine($"Число не четное: {numberA}");
}