using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Daxil Edin !");
        int n = int.Parse(Console.ReadLine());

        generateSquare(n);
    }

    static void generateSquare(int n)
    {
        int[,] sehirliKvadrat = new int[n, n];

        int i = n / 2;
        int j = n - 1;
        for (int num = 1; num <= n * n;)
        {
            if (i == -1 && j == n) 
            {
                j = n - 2;
                i = 0;
            }
            else
            {
                if (j == n)
                    j = 0;

                if (i < 0)
                    i = n - 1;
            }

            if (sehirliKvadrat[i, j] != 0)
            {
                j -= 2;
                i++;
                continue;
            }
            sehirliKvadrat[i, j] = num++;
            j++; i--;
        }
        Console.WriteLine($"Sehirli Kvadratin Uzunlugu {n} olub");

        Console.WriteLine($"Setri Sutun Dioganal Boyu cemi ise {n * (n * n + 1) / 2} ");
                       

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
                Console.Write(sehirliKvadrat[i, j] + " ");
            Console.WriteLine();
        }
    }
}