// задать двумерный массив размером n * n заполненный случайными целыми числами. Как красиво сделать вывод если числа с разным количеством разрядов

int Inputnum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns) 
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] ints, int minValue, int maxValue) 
{
    Random rnd = new Random();
    for (int i = 0; i < ints.GetLength(0); i++)
    {
      for (int j = 0; j < ints.GetLength(1); j++)
      {
        ints[i, j] = rnd.Next(minValue, maxValue + 1); 
      }  
    }
}


void Print2DArray(int[,] ints) 
{
    for (int i = 0; i < ints.GetLength(0); i++)
    {
      for (int j = 0; j < ints.GetLength(1); j++)
      {
        Console.Write(ints[i, j]+ "\t"); // вместо " " укажем "\t". Табуляция дает на каждое значение 8 пробелов
        // либо так: Console.Write($"{ints[i, j]}\t");
      }  
      Console.WriteLine();
    }
}

// запрашиваем данные
int rows = Inputnum("Введите количество строк: ");
int cols = Inputnum("Введите количество столбцов: ");
int min = Inputnum("Введите минимальное значение диапазона: ");
int max = Inputnum("Введите максимальное значение диапазона: ");

// создаем массив
int[,] anyArray = Create2DArray(rows, cols);

// заполняем и печатаем
Fill2DArray(anyArray, min, max); 
Print2DArray(anyArray);
 
 // вывод с применением табуляции выравнивается по левой стороне