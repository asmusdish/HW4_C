// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigit(int num)
{
    int result = 0; 
    while(num > 0)
   {
     result = result + num % 10;
     num = num / 10;
   }
     return result;
}

Console.WriteLine("Cумма цифр в числе");
Console.WriteLine("Введите положительное число: ");

if (!int.TryParse(Console.ReadLine(), out int num) || num < 0) {
    Console.WriteLine("Введено не верное число");
    return;
}

int result = SumDigit(num);
Console.WriteLine($"Результат: {result}");