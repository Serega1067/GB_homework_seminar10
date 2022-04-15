/*
Задача: 
Заданы 2 массива: info и data. В массиве info хранятся двоичные 
представления нескольких чисел (без разделителя). В массиве data 
хранится информация о количестве бит, которые занимают числа из 
массива info. Напишите программу, которая составит массив 
десятичных представлений чисел массива data с учётом информации 
из массива info.

Комментарий: первое число занимает 2 бита (01 -> 1); второе число 
занимает 3 бита (111 -> 7); третье число занимает 3 бита (000 -> 0; 
четвёртое число занимает 1 бит (1 -> 1).

Пример:

входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }

выходные данные:
1, 7, 0, 1
*/

void PrintConvertNumber(int[] argData, int[] argInfo)
{
    int count = 0;
    for (int i = 0; i < argInfo.Length; i++)
    {
        double[] numberBin = new double[argInfo[i]];
        for (int j = count; j < count + argInfo[i]; j++)
        {
            numberBin[j - count] = argData[j];
        }
        count += argInfo[i];

        Console.Write(ConvertBinToDec(numberBin));

        if (i == argInfo.Length - 1) Console.WriteLine();
        else Console.Write(", ");
    }
}

double ConvertBinToDec(double[] argBin)
{
    double numberDec = 0;
    for (int i = 0; i < argBin.Length; i++)
    {
        numberDec += argBin[i] * Math.Pow(2, argBin.Length - 1 - i);
    }
    return numberDec;
}

int[] data = new int[] {0, 1, 1, 1, 1, 0, 0, 0, 1};
int[] info = new int[] {2, 3, 3, 1};

Console.WriteLine("Входные данные:\n" +
                  "data = {0, 1, 1, 1, 1, 0, 0, 0, 1}\n" +
                  "info = {2, 3, 3, 1}\n");
Console.WriteLine("Выходные данные:");

PrintConvertNumber(data, info);
