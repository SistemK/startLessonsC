Console.WriteLine("пределение большего числа из двух");
Console.WriteLine("Введите чисто A: ");
int numberA = int.Parse(Console.ReadLine()?? "Введено некоректное значение, необходимо ввести цифру");
Console.WriteLine("Введите чисто B: ");
int numberB = int.Parse(Console.ReadLine()?? "Введено некоректное значение, необходимо ввести цифру");
if (numberA > numberB)
{
    Console.WriteLine($"Число A больше числа B: {numberA}");
}
else
{
    Console.WriteLine($"Число B больше числа A: {numberB}");
}

