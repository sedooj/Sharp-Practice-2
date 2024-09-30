using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Выберите задание (1-4) или 0 для выхода:");
            Console.WriteLine("1: Массив размерности N в обратном порядке");
            Console.WriteLine("2: Квадратный массив с диагональю");
            Console.WriteLine("3: Спиральный квадратный массив");
            Console.WriteLine("4: Спиральный массив M x N");
            Console.WriteLine("0: Выход");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 0:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    // Задание 1: Массив размерности N в обратном порядке
    static void Task1()
    {
        Console.WriteLine("Введите размерность массива N:");
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = i + 1;
        }

        Console.WriteLine("Массив в обратном порядке:");
        for (int i = N - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    // Задание 2: Квадратный массив с диагональю
    static void Task2()
    {
        Console.WriteLine("Введите размерность квадратного массива:");
        int N = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i + j < N)
                    matrix[i, j] = 1;
                else
                    matrix[i, j] = 0;
            }
        }

        Console.WriteLine("Квадратный массив с диагональю:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Задание 3: Спиральный квадратный массив
    static void Task3()
    {
        Console.WriteLine("Введите размерность квадратного массива:");
        int N = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, N];
        int num = 1;
        int left = 0, right = N - 1, top = 0, bottom = N - 1;

        while (left <= right && top <= bottom)
        {
            for (int i = left; i <= right; i++)
                matrix[top, i] = num++;
            top++;

            for (int i = top; i <= bottom; i++)
                matrix[i, right] = num++;
            right--;

            for (int i = right; i >= left; i--)
                matrix[bottom, i] = num++;
            bottom--;

            for (int i = bottom; i >= top; i--)
                matrix[i, left] = num++;
            left++;
        }

        Console.WriteLine("Спиральный квадратный массив:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Задание 4: Спиральный массив M x N
    static void Task4()
    {
        Console.WriteLine("Введите количество строк (M):");
        int M = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов (N):");
        int N = int.Parse(Console.ReadLine());

        int[,] matrix = new int[M, N];
        int num = 1;
        int left = 0, right = N - 1, top = 0, bottom = M - 1;

        while (left <= right && top <= bottom)
        {
            for (int i = left; i <= right; i++)
                matrix[top, i] = num++;
            top++;

            for (int i = top; i <= bottom; i++)
                matrix[i, right] = num++;
            right--;

            for (int i = right; i >= left; i--)
                matrix[bottom, i] = num++;
            bottom--;

            for (int i = bottom; i >= top; i--)
                matrix[i, left] = num++;
            left++;
        }

        Console.WriteLine("Спиральный массив M x N:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
