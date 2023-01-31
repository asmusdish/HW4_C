// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

void PrintArray(float[] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
        if (i<array.Length-1) 
            Console.Write(array[i].ToString("#.0") + " ");
        else
            Console.Write(array[i].ToString("#.0") + "]");
            Console.WriteLine("");
}
float[] GenerateArr(int n, int min, int max)
{
    float[] arrNum = new float[n];

    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max) + (float)(rnd.Next(0, 10))/10) { }
    return arrNum;
}

float DifMinMax(float[] array)
{
    float min = array [0];
    float max = array [0];
    float result = 0;
    for (int i = 0; i < array.Length; i++)
            {
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
            }
    result = max - min;
    return result;
}

float[] array = GenerateArr(4, -100, 100);
PrintArray(array);

float dif = DifMinMax(array);

Console.WriteLine($"Разница между минимальным и максимальным значениями: {dif}");