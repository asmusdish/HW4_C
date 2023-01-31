// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void PtintArray(int[] array)
{
    System.Console.Write($"[{String.Join(",", array)}]\n");
}
int[] GenerateArr(int n, int min, int max)
{
    int[] arrNum = new int[n];

    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }
    return arrNum;
}

int SumOdd(int[] array)
{
    int result = 0;

    for (int i = 1; i < array.Length; i += 2)
            result += array[i];
    return result;
}

int[] array = GenerateArr(4, -100, 100);
PtintArray(array);

int sum = SumOdd(array);

Console.WriteLine($"Сумма нечетных позиций массива: {sum}");