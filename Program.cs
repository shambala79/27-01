// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Sort(array);
PrintArray(array);
// -------------------Методы---------------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Sort(int[,] Array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {

            for (int x = j + 1; x < array.GetLength(1); x++)
            {

                if (Array[i, j] < Array[i, x])
                {
                    int temp = Array[i, j];
                    Array[i, j] = Array[i, x];
                    Array[i, x] = temp;
                }

            }
        }
    }
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк: ");
int rows1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns1 = int.Parse(Console.ReadLine()!);

int[,] array1 = GetArray(rows1, columns1, 0, 10);
PrintArray(array1);

int[] SumRow = GetSumRow(array1);
int min = SumRow[0];
int mini = 1;
for (int h = 0; h < SumRow.Length; h++)
{
    if (min > SumRow[h])
    {
        min = SumRow[h];
        mini = h + 1;
    }
}
Console.WriteLine($"[{String.Join("; ", SumRow)}]");
Console.WriteLine($"Минимальная сумма {min} строка {mini}");
//-------------------Методы---------------------------------
int[] GetSumRow(int[,] ar)
{
    int[] SumArray = new int[ar.GetLength(0)];
    int[] Index = new int[ar.GetLength(0)];

    for (int i = 0; i < ar.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            sum = sum + ar[i, j];

        }
        SumArray[i] = sum;
    }
    return SumArray;
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк матрицы А: ");
int rowsA = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов матрицы А: ");
int columnsA = int.Parse(Console.ReadLine()!);

int[,] matrixA = GetArray(rowsA, columnsA, 1, 9);
PrintArray(matrixA);

Console.Write("Введите количество строк матрицы B: ");
int rowsB = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов матрицы B: ");
int columnsB = int.Parse(Console.ReadLine()!);

int[,] matrixB = GetArray(rowsB, columnsB, 1, 9);
PrintArray(matrixB);

if (columnsA != rowsB) Console.WriteLine("Произведение матриц А и В невозможно!");
else
{
    Console.WriteLine();
    int[,] Resalt = MatrixProduct(matrixA, matrixB);
    PrintArray(Resalt);
}
//-------------------Методы---------------------------------
int[,] MatrixProduct(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixA.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int k = 0; k < matrixB.GetLength(1); k++)
        {
            int sum = 0;
            for (int j = 0; j < matrixA.GetLength(1); j++)
            {
                for (int n = 0; n < matrixB.GetLength(0); n++)
                {
                    int p;
                    p = matrixA[i, j] * matrixB[n, k];
                    j++;
                    sum = sum + p;
                }
            }
            matrixC[i, k] = sum;
        }
    }
    return matrixC;
}

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите количество строк: ");
int rows3 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns3 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество слоёв: ");
int layer3 = int.Parse(Console.ReadLine()!);

if (rows3 * columns3 * layer3 >= 100)
{ Console.Write("Создать такой массив невозможно!!!"); }
else
{
    int[,,] Array3 = GetArray3(rows3, columns3, layer3, 10, 99);
    PrintArray3(Array3);
}

// -------------------Методы---------------------------------
int[,,] GetArray3(int m, int n, int k, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int z = 0;
            while (z < k)
            {
                int element = new Random().Next(minValue, maxValue + 1);
                if (FindElement(result, element)) continue;
                result[i, j, z] = element;
                z++;
            }
        }
    }

    return result;
}
bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}

void PrintArray3(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)

            {

                Console.Write($"{String.Join(" ", array[i, j, z], "(", i, j, z, ")")}");
            }
            Console.WriteLine();
        }
    }
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int x = 4;
int[,] Spiral = new int[x, x];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= Spiral.GetLength(0) * Spiral.GetLength(1))
{
    Spiral[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < Spiral.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= Spiral.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > Spiral.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(Spiral);
//-------------------Методы---------------------------------
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($"0{array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}