//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.Write("Введите число :   ");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigit = 0;

while (number > 0)
        {
            int digit = number % 10;
            sumDigit = sumDigit + digit;
            number = number / 10;
        }
System.Console.Write($"Сумма цифр числа равна {sumDigit} ");
