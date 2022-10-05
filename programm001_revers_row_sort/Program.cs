// Программа, которая упорядочит по убыванию элементы каждой строки двумерного массива

System.Console.WriteLine("Введите количество строк");
int rowsCount = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int columnsCount = Convert.ToInt32(Console.ReadLine());

// Задаем двумерный массив случайных целых чисел
int[,] twoDimArray = new int[rowsCount, columnsCount];
Random rnd = new Random();
for (int i = 0; i < rowsCount; i++)
{
    for (int j = 0; j < columnsCount; j++)
    {
        twoDimArray[i, j] = rnd.Next(1, 100);
        System.Console.Write(twoDimArray[i, j] + "\t");

    }
    System.Console.WriteLine();
}

System.Console.WriteLine();

// пузырьковая сортировка i-ой строки по убыванию
int tmp_element = 0;
for (int i = 0; i < rowsCount; i++)
{
     
    for (int j = 0; j < columnsCount; j++)
    {
        for (int k = j; k < columnsCount; k++)
        {
            if (twoDimArray[i,k] > twoDimArray[i,j])
            {
                tmp_element = twoDimArray[i,j];
                twoDimArray[i,j] = twoDimArray[i,k];
                twoDimArray[i,k] = tmp_element;
            }
        }
    }

}

//вывод на экран получившегося массива
for (int i = 0; i < rowsCount; i++)
{
    for (int j = 0; j < columnsCount; j++)
    {
        System.Console.Write(twoDimArray[i, j] + "\t");
    }
    System.Console.WriteLine();
}