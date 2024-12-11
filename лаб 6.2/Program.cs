using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 6;
        int m = 6;
        int[,] matrix = new int[n, m];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = random.Next(-10, 11);
            }
        }
        Console.WriteLine("Сгенерированная матрица:");
        PrintMatrix(matrix, n, m);
        int sumOfNegatives = CalculateSumOfNegatives(matrix, n, m);
        Console.WriteLine($"Сумма модулей отрицательных элементов над главной диагональю: {sumOfNegatives}");
    }
static void PrintMatrix(int[,] matrix, int n, int m)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
static int CalculateSumOfNegatives(int[,] matrix, int n, int m)
    {
        int sum = 0;
for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < m; j++)
            {
                if (matrix[i, j] < 0)
                {
                    sum += Math.Abs(matrix[i, j]);
                }
            }
        }

        return sum;
    }
}

