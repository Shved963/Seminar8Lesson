// Задайте двумерный массив.
// Напишите программу, которая поменяет
// местами первую и последнюю строку массива.

using static Common.Helper;

Console.Clear();
Console.WriteLine("Введите размер двумерного массива");
(int[,], int[,]) array = Create2DArray();
Common.Helper.PrintArray(array.Item1);
int[,] reversedArray = GetReversedArray(array.Item1, array.Item2);
Console.WriteLine();
Common.Helper.PrintArray(reversedArray);




int[,] GetReversedArray(int[,] array, int[,] secondArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                secondArray[i, j] = array[array.GetLength(0) - 1, j];
            }
            else
            if (i == array.GetLength(0) - 1)
            {
                secondArray[i, j] = array[0, j];
            }
        }
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
