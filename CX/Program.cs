int number = GetUserNumber("Введите число: ","Ошибка");
int result = CountDidgits(number);
System.Console.WriteLine(result);

#region 
int CountDidgits(int number)
{
    int count = 0;
    while (number != 0)
    {
        count++;
        number /= 10;
    }
    return count;
}

int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        int userInput;
        if (int.TryParse(Console.ReadLine(), out userInput))
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}
#endregion