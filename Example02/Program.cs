// Задайте двумерный массив.
// Напишите программу, которая заменяет
// строки на столбцы.
// В случае, если это невозможно,
// программа должна вывести сообщение
// для пользователя.

using static Common.Helper;
//дописать условие для вводимых отрицательных чисел
Console.Clear();

Console.WriteLine("Введите размер двумерного массива");
(int[,], int[,]) array = Create2DArray();
Console.WriteLine();
Common.Helper.PrintArray(array.Item1);
Console.WriteLine();
int[,] reversedArray = GetRreversedArray(array.Item1,array.Item2);
Common.Helper.PrintArray(reversedArray);

int[,] GetRreversedArray(int[,] array, int[,] secondArray)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                secondArray[i, j] = array[j, i];
            }
        }
    }
    else
    {
        throw new Exception("Невозможно перевернуть массив, колличество строк должно ровняться колличеству столбцов");
    }
    return secondArray;
}


(int[,], int[,]) Create2DArray()
{
    int countOfRow = Common.Helper.IntoInt();
    int countOfColums = Common.Helper.IntoInt();

    Random random = new Random();

    int[,] array = new int[countOfRow, countOfColums];
    int[,] secondArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-20, 21);
            secondArray[i, j] = array[i, j];
        }
    }

    return (array, secondArray);
}