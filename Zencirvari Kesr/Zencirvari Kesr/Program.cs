using System;

namespace Zencirvari_Kesr
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dividedByZero = false;
            int temp = 0;
            bool end = true;
            Console.WriteLine("Enter First Value :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Value :");
            int y = int.Parse(Console.ReadLine());
            int[] z = { };
            int[] A = { };
            do
            {
                Array.Resize(ref A, A.Length + 1);
                A[A.Length - 1] = x / y;
                Array.Resize(ref z, z.Length + 1);
                z[z.Length - 1] = x % y;

                temp = y;
                y = x % y;
                x = temp;

                if (y == 0)
                {
                    end = false;
                }
                else
                {
                    if (y != 1)
                    {
                        if (x % y == 0)
                        {
                            dividedByZero = true;
                            end = false;
                        }
                    }
                    else
                    {
                        end = true;
                    }
                    if (x % y == 1)
                    {
                        if (x + 1 == y || x - 1 == y)
                        {
                            end = true;
                        }
                        else
                        {
                            end = false;
                        }
                    }
                    else if (x % y < 1)
                    {
                        end = false;
                    }
                }
            }
            while (end);
            if (dividedByZero)
            {
                Console.WriteLine("0 - a bolme emeliyyati var. Uygunsuzluq !!!");
            }
            else
            {
                string text = "";
                foreach (var tamHisse in A)
                {
                    text += $"{tamHisse} ";
                }
                text += y;
                Console.WriteLine(text);
            }
        }
    }
}