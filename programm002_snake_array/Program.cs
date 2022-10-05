// Программа, которая спирально заполнит числами от 1 до 16 двумерный массив 4 на 4
// При заполнении массива использовать циклы

//замерность массива
int N = 4;


// метод заполнения массива по спирали
int[,] fill_spiral(int n) {
    int[,] result = new int[n, n];

    int pos = 1;
    int count = n;
    int value = -n;
    int sum = -1;

    while (count > 0) {
        value = -1 * value / n;
        for (int i = 0; i < count; i++) {
            sum += value;
            result[sum / n, sum % n] = pos++;
        }
        value *= n;
        count--;
        for (int i = 0; i < count; i++) {
            sum += value;
            result[sum / n, sum % n] = pos++;
        }
    } 

    return result;
}

//заполнение массива по спирали
int[,] twoDimArray = fill_spiral(N);

//вывод получившегося массива
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        System.Console.Write(twoDimArray[i, j] + "\t");

    }
    System.Console.WriteLine();
}