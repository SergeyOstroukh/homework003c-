Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Reverse(int number)
{   
    int reversedNumber = 0;
    while (number > 0)
    {
        reversedNumber = reversedNumber * 10 + number % 10;
        number = number / 10;

    }
    return reversedNumber;
}
if (num == Reverse(num)) Console.WriteLine($"Число {num} является палиндроном.");
else Console.WriteLine($"Число {num} не является палиндромом.");