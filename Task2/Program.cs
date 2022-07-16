// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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

Console.Write("Enter the line number of the number you are looking for: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the column number of the number you are looking for: ");
int j = Convert.ToInt32(Console.ReadLine());

if (i > myArr.GetLength(0) || j > myArr.GetLength(1)) {
    Console.WriteLine("Числа под такой позицией не существует");
}
else {
    Console.WriteLine(myArr[i - 1,j - 1]);
}