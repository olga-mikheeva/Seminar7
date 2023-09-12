// задать двумерный массив. Найти элементы у которых оба индекса четные и заменить эти элементы на их квадраты

int Inputnum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns) // функция которой задаем массив с каким-то количеством строк и столбцов. она возвращает наш массив
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] ints, int minValue, int maxValue) // функция которая заполняет массив случайными числами
{
    Random rnd = new Random();
    for (int i = 0; i < ints.GetLength(0); i++)
    {
      for (int j = 0; j < ints.GetLength(1); j++)
      {
        ints[i, j] = rnd.Next(minValue, maxValue + 1); // элементу массива i- ой строки и j-ого столбца присвоим случайное число сгенерированное с помощью метода Next
      }  
    }
}

// принцип работы метода Next: когда мы указываем дтапазон от (2, 5) то фактически формируется диапазон -> [2, 4]  т.е. полуинтервал [2, 5) 
// чтобы не вводить пользователя в заблуждение если он max задал 5, то мы вынуждены к maxValue прибавить 1

void Print2DArray(int[,] ints) // функция которая выводит массив(печатает)
{
    for (int i = 0; i < ints.GetLength(0); i++)
    {
      for (int j = 0; j < ints.GetLength(1); j++)
      {
        Console.Write(ints[i, j]+ " "); // выводим значение текущего элемента и в конце цикла который идет по столбцам одной строки мы переходим на новую строку и ставим пустую строку, чтобы не сливались
      }  
      Console.WriteLine();
    }
}




void ConvertArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] *= array[i,j];
        }
    }
}


// запрашиваем данные
int rows = Inputnum("Введите количество строк: ");
int cols = Inputnum("Введите количество столбцов: ");
int min = Inputnum("Введите минимальное значение диапазона: ");
int max = Inputnum("Введите максимальное значение диапазона: ");

// создаем массив
int[,] anyArray = Create2DArray(rows, cols);

Fill2DArray(anyArray, min, max); 
Print2DArray(anyArray);
System.Console.WriteLine();
ConvertArray(anyArray);
Print2DArray(anyArray);