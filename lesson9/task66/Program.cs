// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


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

int sumNum(int M, int N)
{
    int summ = 0;
    if(M <= N) return summ = M+sumNum(M+1, N);
    else return summ;
}

int M = getNumber("Введите значение M");
int N = getNumber("Введите значение N");
Console.WriteLine(sumNum(M,N));