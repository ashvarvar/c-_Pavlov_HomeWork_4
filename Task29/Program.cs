// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
      
Console.Write("Введите размер массива :   ");
int SizeArray = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[SizeArray];
    
    for (int i=0; i<SizeArray; i++)
        {
            Console.Write("Введите число :   ");
            myArray[i] = Convert.ToInt32(Console.ReadLine());
        }

    for (int i = 0; i < SizeArray; i++)
        {
            Console.Write($"{ myArray[i]} ");
        }
