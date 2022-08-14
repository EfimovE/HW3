// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void PrintThirdDegree (int number)
{
    int i = 1;
    if (number < 1)
    {
        Console.WriteLine("Введите число > 1.");
        return;
    }
    while (i <= number)
    {
        Console.WriteLine($"{i}  |   {Math.Pow(i,3)}");
        i++;
    }
}
Console.WriteLine("Введите число больше 1.");
int num = Convert.ToInt32(Console.ReadLine());
PrintThirdDegree (num);
