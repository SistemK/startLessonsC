int getNumber(string message)
{
    Console.WriteLine(message);
    int number = 0;
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out number))
        {
           return number;
        }
        else 
        {
            Console.WriteLine("Необходимо ввести цифру!");
            Console.WriteLine("------------------------");
        }
    }
}

double[] cube (int number)
{
    double[] arr = new double[number];
    for (int i = 0; i < number; i++)
    {
        arr[i] = Math.Pow(i+1, 3);
    }
    return arr;
}

int number = getNumber("Введите число");
double[] arrCube = cube(number);

for (int i = 0; i < arrCube.Length; i++)
{
    Console.WriteLine($"Число {i+1} в кубе = {arrCube[i]}");
}