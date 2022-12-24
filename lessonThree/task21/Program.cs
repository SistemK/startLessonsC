int putCoordinates (string message)
{
    Console.WriteLine(message);
    int coordinates = 0;
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out coordinates))
        {
            return coordinates;
        }
        else 
        {
            Console.WriteLine("Необходимо ввести цифру!");
            Console.WriteLine("------------------------");
        }
    }
}

void distanceCoordinates(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double AB = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
    Console.WriteLine($"Расстояние между координатами в 3D пространстве: {AB}");
}


int x1 = putCoordinates ("Введи кооринату x1");
int y1 = putCoordinates ("Введи кооринату y1");
int z1 = putCoordinates ("Введи кооринату z1");

int x2 = putCoordinates ("Введи кооринату x2");
int y2 = putCoordinates ("Введи кооринату y2");
int z2 = putCoordinates ("Введи кооринату z2");

distanceCoordinates(x1,x2,y1,y2,z1,z2);

