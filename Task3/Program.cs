// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue) {
    int[,] newArr = new int[rows, columns];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++) {
            newArr[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArr;
}

void Show2dArray (int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void ShowArray (double[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

double[] CalculateAverageOnRows (int[,] arr) {
    double[] averageArr = new double[arr.GetLength(1)];
    double sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++) {
        for (int j = 0; j < arr.GetLength(0); j++) {
            sum = arr[j,i] + sum;
        }
        sum /= arr.GetLength(0);
        averageArr[i] = sum;
        sum = 0;
    }
    return averageArr;
}

Console.Write("enter the number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("enter the number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("enter the number min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("enter the number max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArr =  CreateRandom2dArray(m, n, min, max);

Console.WriteLine();

Show2dArray(myArr);

Console.WriteLine();

double[] averageArr =  CalculateAverageOnRows(myArr);

Console.WriteLine("Average number for each column of a two-dimensional array:");
ShowArray(averageArr);