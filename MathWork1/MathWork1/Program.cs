using System;

namespace MathWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Sade Iterasiya Usulu\nTenliklerin Sayini daxil edin :");
            string tenlikSayStr = Console.ReadLine();
            int tenlikSay;
            while (!int.TryParse(tenlikSayStr, out tenlikSay) && tenlikSay == 0)
            {
                Console.WriteLine("Duzgun daxil edin !");
                tenlikSayStr = Console.ReadLine();
            }
            Console.WriteLine($"{Tenlik(tenlikSay)}");
            double[,] nums = new double[tenlikSay , tenlikSay];
            Console.WriteLine("Uygun Olaraq Emsallari Daxil Edin :");
            for (int i = 0; i < tenlikSay; i++)
            {
                for (int j = 0; j < tenlikSay; j++)
                {
                    Console.WriteLine($"Daxil Edin {i}.{j}:");
                    double num = double.Parse(Console.ReadLine());
                    nums[i, j] = num;
                    
                }
            }
            Console.WriteLine(TenlikEmsal(tenlikSay,nums));
            
            static string Tenlik(int say)
        {
                string tenlik = "";
                for (int j = 0; j < say; j++)
                {
                    for (int i = 0; i < say; i++)
                    {
                        if (i == say-1)
                        {
                            tenlik += $"({j}.{i})X{i}";
                            break;
                        }
                        tenlik += $"({j}.{i})X{i}+";
                    }
                    tenlik += "\n";
                }

                return tenlik;
        }
            static string TenlikEmsal(int say, double[,] nums)
            {
                string tenlik = "";
                for (int j = 0; j < say; j++)
                {
                    for (int i = 0; i < say; i++)
                    {
                        if (i == say - 1)
                        {
                            tenlik += $"{nums[i,j]}X{i}";
                            break;
                        }
                        tenlik += $"{nums[i, j]}X{i}+";
                    }
                    tenlik += "\n";
                }

                return tenlik;
            }
        }
    }
}
