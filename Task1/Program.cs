// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue) {
    double[,] newArr = new double[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++) {
            newArr[i,j] = Math.Round((new Random().Next(minValue, maxValue + 1)) + new Random().NextDouble(), 2);
        }
    }
    return newArr;
}

void Show2dArray (double[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("enter the number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("enter the number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("enter the number min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("enter the number max value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArr =  CreateRandom2dArray(m, n, min, max);

Console.WriteLine();

Show2dArray(myArr);