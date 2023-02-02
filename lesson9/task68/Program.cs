// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int getNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result)) break;
        else Console.WriteLine("Введены не корректные данные.");
    }
    
    return result;
}

int akker(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return akker(m - 1, 1);
    if (m > 0 && n > 0) return akker(m - 1, akker(m, n - 1));
   return akker(m,n);
}

int M = getNumber("Введите значение M");
int N = getNumber("Введите значение N");
Console.WriteLine($"A({M},{N}) = {akker(M,N)}");