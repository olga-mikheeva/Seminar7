// задать двумерный массив размером m * n где каждый элемент в массиве находится по формуле A(mn) = m + n Выведите полученный массив на экран
// m = 3; n = 4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// нам неизвестно ск строк и столбцов будет в массиве, запрашиваем 

int Inputnum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

// объявляем и инициализируем массив

int[,] CreateArr(int first, int second) 
{
    int[,] array = new int[first, second];
    return array;
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
        arr[i, j] = i + j;
       } 
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
        Console.Write(arr[i, j] + " ");
       } 
       Console.WriteLine();
    }
}

int rows = Inputnum("Введите количество строк: ");
int columns = Inputnum("Введите количество столбцов");

int[,] anyArray = CreateArr(rows, columns);
FillArray(anyArray); 
PrintArray(anyArray);