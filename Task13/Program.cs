// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckPalindrome (int num)
{
    if (num < 10000 || num > 99999) Console.WriteLine("Вы ввели некорректное число.");
    else if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10) Console.WriteLine($"{num} -> Да.");
    else Console.WriteLine($"{num} -> Нет.");
}
Console.WriteLine("Введите пятизначное число и нажмите Enter.");
int number = Convert.ToInt32(Console.ReadLine());
CheckPalindrome (number);
