//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int InputInt(string message)
{
    System.Console.Write(message + ">");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;

}
bool ValidateNumberRank3(int number)
{
    if (number > 99 && number < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Число НЕ трехзначное");
    return false;
}

int number = InputInt("ВВедите трехзначное число");
if (ValidateNumberRank3(number))
{
    number = number / 10;
    number = number % 10;
    System.Console.WriteLine($"Вторая цифра числа это {number}");
}