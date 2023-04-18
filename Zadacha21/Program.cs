//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
int x1 = GetUserNumber("Введите значение точки А x1: ");
int y1 = GetUserNumber("Введите значение точки А y1: ");
int z1 = GetUserNumber("Введите значение точки А z1: ");
int x2 = GetUserNumber("Введите значение точки В х1: ");
int y2 = GetUserNumber("Введите значение точки В y1: ");
int z2 = GetUserNumber("Введите значение точки D z1: ");

double result = Math.Sqrt (Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"a ({x1},{y1},{z1}); b ({x2},{y2},{z2}) -> {result:f2}");

static int GetUserNumber(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        int userImput;
        if (int.TryParse(Console.Readline(), out userImput))
        {
            return (userImput);
        }
        else Console.WriteLine("Введены некорректные данные"); 
    }
}
    
    