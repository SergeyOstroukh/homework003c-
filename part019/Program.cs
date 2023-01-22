// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

number = number < 0 ? -number : number;
if (number < 10000 || number > 99999)
{
    Console.WriteLine($"Число {number} не является пятизначным, введите пятизначное число");
    return;
}

if (Palindrom(number) == true) Console.WriteLine($"Число {number} является палиндромом.");
else
    Console.WriteLine($"Число {number} не является палиндромом.");

bool Palindrom(int num)
{
    bool result;
    int num1 = number / 10000;
    int num2 = number / 1000 % 10;
    int num4 = number / 10 % 10;
    int num5 = number % 10;
    if (num1 == num5 && num2 == num4) result = true;
    else
        result = false;
    return result;
}
