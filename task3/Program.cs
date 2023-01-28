// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]

void FillArray(int[] array)
{
    for(int i = 0; i < 8; i++)
    {
        Console.WriteLine($"Введите {i}-й элемент массива: ");
        if (!int.TryParse(Console.ReadLine(), out int num)) {
    Console.WriteLine("Введено не верное число");
    return;
    }
    array[i] = num;
    }
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < 8; i++)
    {
        if(i != 7) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int[] array = new int[8];
FillArray(array);
Console.WriteLine("Итоговый массив:");
PrintArray(array);