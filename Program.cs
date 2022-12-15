/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */


/* void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
Console.Clear();
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Bведите n");
int n = int.Parse(Console.ReadLine());
double[,] numbers = new double[m, n];
FillArrayRandomNumbers(numbers);
PrintArray(numbers); */


/* Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
 этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */


/* int m, n; 
 int value = 1; 
 Console.Write("Введите кол-во строк: "); 
 m = Int32.Parse(Console.ReadLine()); 
 Console.Write("Введите кол-во столбцов: "); 
 n = Int32.Parse(Console.ReadLine()); 
 Random rnd = new Random(); 
 int[,] numbs = new int[m, n]; 
 int row = rnd.Next(numbs.GetLength(0)+1); 
 int col = rnd.Next(numbs.GetLength(1)+1); 
 for (int i = 0; i<m; i++) 
 { 
 for (int j = 0; j < n; j++) 
 { 
 numbs[i, j] = value; 
 Console.Write(numbs[i, j] + " "); 
 value++; 
 } 
 Console.WriteLine(); 
 } 

 { 
Console.Write("Введите номер строки: ");
int a = Int32.Parse(Console.ReadLine()) -1; 
Console.Write("Введите номер столбца: ");
int b = Int32.Parse(Console.ReadLine()) -1;
if (a > m && b > n)
Console.WriteLine("Нет такого");
else
{
    object c = numbs.GetValue(a,b);
    Console.WriteLine(c);
}
} */


/* Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int m, n; 
 int value = 1; 
 Console.Write("Введите кол-во строк: "); 
 m = Int32.Parse(Console.ReadLine()); 
 Console.Write("Введите кол-во столбцов: "); 
 n = Int32.Parse(Console.ReadLine()); 
 Random rnd = new Random(); 
 int[,] numbs = new int[m, n]; 
 int row = rnd.Next(numbs.GetLength(0)+1); 
 int col = rnd.Next(numbs.GetLength(1)+1); 
 for (int i = 0; i<m; i++) 
 { 
 for (int j = 0; j < n; j++) 
 { 
 numbs[i, j] = value; 
 Console.Write(numbs[i, j] + " "); 
 value++; 
 } 
 Console.WriteLine(); 
 } 

for (int i = 0; i < n; i ++)
{
   int sum = 0;
   for (int j = 0; j < m; j++) sum += numbs[j, i];

   Console.WriteLine((double)sum / m);
}