
using System;

namespace Sade_Iterasiya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Epslon daxil edin!");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine("Deyisen Sayi daxil edin (X)");
            int olcu = int.Parse(Console.ReadLine());
            double[,] emsallar = new double[olcu, olcu + 1];
            double[] xN = new double[olcu];
            string text = "";
            for (int i = 0; i < olcu ; i++)
            {
                for (int j = 0; j < olcu +1; j++)
                {
                    if (j == olcu)
                    {
                        text += $"({i}.{j})";
                    }
                    else if (j == 0) 
                    {
                        text += $"X({i}) = ({i}.{j})X{j} +";
                    }
                    else
                    {
                        text += $"({i}.{j})X{j} +";
                    }
                }
                text += "\n";
            }
            Console.WriteLine(text);
            double num;
            for (int i = 0; i < olcu; i++)
            {
                for (int j = 0; j < olcu +1; j++)
                {
                    Console.WriteLine($"Daxil Edin : {i}.{j}");
                    num = double.Parse(Console.ReadLine());
                    emsallar[i, j] = num;
                }
            }
            string text2 = "";
            for (int i = 0; i < olcu; i++)
            {
                for (int j = 0; j < olcu + 1; j++)
                {
                    if (j == olcu)
                    {
                        if (emsallar[i, j] > 0)
                        {
                            text2 += $"+ {emsallar[i, j]}";
                        }
                        else
                        {
                            text2 += $"{emsallar[i, j]}";
                        }

                    }
                    else if (j == 0) 
                    {
                        text2 += $"X({i}) = {emsallar[i, j]}X{j} ";
                    }
                    else
                    {
                        if (emsallar[i, j] > 0)
                        {
                            text2 += $"+ {emsallar[i, j]}X{j} ";
                        }
                        else
                        {
                            text2 += $"{emsallar[i, j]}X{j} ";
                        }
                    }
                }
                text2 += "\n";
            }
            Console.WriteLine(text2);
            for (int i = 0; i < olcu; i++)
            {
                xN[i] = emsallar[i, olcu];
            }
            bool check = true;
            double sum ;
            double[] xDifference = new double[olcu];
            while (check)
            {
                for (int i = 0; i < olcu; i++)
                {
                    sum = 0; 
                    for (int j = 0; j < olcu; j++)
                    {
                        sum += emsallar[i, j] * xN[j]; 
                    }
                    sum += emsallar[i,olcu];
                    xDifference[i] = sum;
                }
                for (int i = 0; i < olcu; i++)
                {
                    if ((xN[i] - xDifference[i]) < 0 && (xN[i] - xDifference[i]) * -1 < e)
                    {
                        check = false;
                    }
                }
                for (int i = 0; i < olcu; i++)
                {
                    xN[i] = xDifference[i];
                }
            }
            for (int i = 0; i < olcu; i++)
            {
                Console.WriteLine($"X({i}) = {xN[i]}");
            }
        }
    }
}
