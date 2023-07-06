// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] FillMatrix(int row, int col, int leftRange, int rightRange)
// {
//     double[,] tempMatrix = new double[row, col];
//     // Random rand = new Random();
//     var rand = new Random();

//     for (int i = 0; i < tempMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < tempMatrix.GetLength(1); j++)
//         {
//             tempMatrix[i, j] = Math.Round(rand.Next(leftRange, rightRange) + rand.NextDouble(), 2);
//         }
//     }
//     return tempMatrix;
// }

// void PrintMatrix(double[,] matrixFotPrint)
// {
//     for (int i = 0; i < matrixFotPrint.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixFotPrint.GetLength(1); j++)
//         {
//             System.Console.Write(matrixFotPrint[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// double[,] matrix = FillMatrix(3, 4, -10, 10);
// PrintMatrix(matrix);





// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
// {
//     int[,] tempMatrix = new int[row, col];
//     // Random rand = new Random();
//     var rand = new Random();

//     for (int i = 0; i < tempMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < tempMatrix.GetLength(1); j++)
//         {
//             tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
//         }
//     }

//     return tempMatrix;
// }

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void PrintMatrix(int[,] matrixFotPrint)
// {
//     for (int i = 0; i < matrixFotPrint.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixFotPrint.GetLength(1); j++)
//         {
//             System.Console.Write(matrixFotPrint[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void ChangeElemets(int[,] matrix, int row, int col)
// {
//     if (row > matrix.GetLength(0) || col > matrix.GetLength(1))
//     {
//         Console.WriteLine("Такого числа нет");
//     }
//     else
//     {
//         Console.WriteLine($"Значение элемента {row} строки и {col} столбца равно {matrix[row - 1, col - 1]}");
//     }
// }

// int row = ReadInt("Введите строку: ");
// int col = ReadInt("Введите столбц: ");
// int[,] matrix = FillMatrix(3, 4, 0, 100);
// PrintMatrix(matrix);
// ChangeElemets(matrix, row, col);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
// {
//     int[,] tempMatrix = new int[row, col];
//     // Random rand = new Random();
//     var rand = new Random();

//     for (int i = 0; i < tempMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < tempMatrix.GetLength(1); j++)
//         {
//             tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
//         }
//     }

//     return tempMatrix;
// }

// void PrintMatrix(int[,] matrixFotPrint)
// {
//     for (int i = 0; i < matrixFotPrint.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixFotPrint.GetLength(1); j++)
//         {
//             System.Console.Write(matrixFotPrint[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void Average(int[,] numbers, int row, int col)
// {
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         double avarage = 0;
//         for (int i = 0; i < numbers.GetLength(0); i++)
//         {
//             avarage = (avarage + numbers[i, j]);
//         }
//         avarage = avarage / row;
//         Console.Write(avarage + "; ");
//     }
// }

// int row = 3;
// int col = 4;
// int[,] matrix = FillMatrix(row, col, 0, 100);
// PrintMatrix(matrix);
// Average(matrix, row, col);
