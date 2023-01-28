// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Exponent(int A, int B)
{
    double result = 1;
    for(int i = 0; i < B; i++)
        result = result * A;
    return result;
}

Console.WriteLine("Возведение числа A в натуральную степень B");
Console.WriteLine("Введите число А: ");

if (!int.TryParse(Console.ReadLine(), out int A) || A < 0) {
    Console.WriteLine("Введено не верное число");
    return;
}
Console.WriteLine("Введите число B: ");

if (!int.TryParse(Console.ReadLine(), out int B) || B < 0) {
    Console.WriteLine("Введено не верное число");
    return;
}

double result = Exponent(A, B);
Console.WriteLine($"Результат: {result}");