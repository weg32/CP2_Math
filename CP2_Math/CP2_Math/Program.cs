namespace CP2_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }

        static void Calculator()
        {
            Console.WriteLine("Введите количество строчек");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] counts = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Введите число для [{i}, {j}]");
                    int val = Convert.ToInt32(Console.ReadLine());

                    bool okLeft = (j == 0 || val > counts[i, j - 1]);
                    bool okTop = (i == 0 || val > counts[i - 1, j]);

                    if (okLeft && okTop)
                    {
                        counts[i, j] = val;
                    }
                    else
                    {
                        Console.WriteLine("Число не подходит");
                        j--;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(counts[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nВведите число для поиска");
            int k = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (counts[i, j] == k)
                    {
                        Console.WriteLine($"Ваше число находится в [{i}, {j}]");
                        return;
                    }
                }
            }
            Console.WriteLine("Вашего числа нету в таблице");
        }
    }
}
