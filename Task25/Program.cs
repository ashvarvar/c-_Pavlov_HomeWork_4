//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.


Console.Write("Введите число A :   ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B :   ");
int exponent = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result = number;

while (count < exponent)
    {
        result = result * number;
        count++;
    }

Console.WriteLine($"{number} ^ {exponent} = {result}");
