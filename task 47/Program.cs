// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4, minLimitRandom = -10, maxLimitRandom = 10

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Clear();
int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите минимальное значение массива: ");
int maxValue = Prompt("Введите максимальное значение массива: ");
double[,] randomArray = new double[m,n];
GetArray(m,n, minValue, maxValue);

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void GetArray(int m, int n, int min, int max)
{
    int i,j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
    {
        // randomArray[i,j] = new Random().Next(min, max);
        randomArray[i,j] = new Random().NextDouble() * 10;
        Console.Write($"{randomArray[i,j]:F2} ");
    } 
    }

}
