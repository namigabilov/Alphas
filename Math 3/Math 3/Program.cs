using System;

namespace Math_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0 = 0;
            Console.WriteLine("Epslon daxil edin !");
            double e = double.Parse(Console.ReadLine());
            double x1 = 0;
            Console.WriteLine("X in en yuksek derecesini daxil edin ;");
            string numStr = Console.ReadLine();
            int num;
            while (!int.TryParse(numStr, out num))
            {
                Console.WriteLine("Duzgun daxil et");
                numStr = Console.ReadLine();
            }
            double[] functionNum = { };
            int k = 1;
            int sub = num;
            while (k <= num + 1)
            {
                if (sub == -1)
                {
                    break;
                }
                Console.WriteLine($"X^{sub} Emsalini Daxil Edin");
                string num1Str = Console.ReadLine();
                double num1;
                while (!double.TryParse(num1Str, out num1))
                {
                    Console.WriteLine("Duzgun daxil et");
                    num1Str = Console.ReadLine();
                }

                Array.Resize(ref functionNum, functionNum.Length + 1);
                functionNum[functionNum.Length - 1] = num1;
                sub -= 1;
            }
            int sub2 = num;
            string text = "F(X) = ";
            for (int i = 0; i < functionNum.Length; i++)
            {
                if (functionNum[i] > 0)
                {
                    if (sub2 != 0)
                    {
                        text += $"+{functionNum[i]}X^{sub2}";
                    }
                    else
                    {
                        text += $"+{functionNum[i]}";
                    }
                }
                else if (functionNum[i] < 0)
                {
                    if (sub2 != 0)
                    {
                        text += $"{functionNum[i]}X^{sub2}";
                    }
                    else
                    {
                        text += $"{functionNum[i]}";
                    }
                }
                if (functionNum[i] == 0)
                {
                    text += "";
                }
                sub2--;
            }
            text += " = 0";
            Console.WriteLine(text);
            double j = 0;

            while (true)
            {
                for (int i = 0; i < functionNum.Length; i++)
                {
                    if (i != functionNum.Length - 1)
                    {
                        double pow = Math.Pow(j, (functionNum.Length - 1 - i));
                        x1 += pow * functionNum[i];
                    }
                    else
                    {
                        x1 += functionNum[functionNum.Length - 1];
                        j++;
                    }
                }
                if (x1 > 0)
                {
                    break;
                }
                x1 = 0;
            }
            x1 = j;
            j = x1;
            while (true)
            {
                for (int i = 0; i < functionNum.Length; i++)
                {
                    if (i != functionNum.Length - 1)
                    {
                        double pow = Math.Pow(j, (functionNum.Length - 1 - i));
                        x0 += pow * functionNum[i];
                    }
                    else
                    {
                        x0 += functionNum[functionNum.Length - 1];
                        j--;
                    }
                }
                if (x0 < 0)
                {
                    break;
                }
                x0 = 0;
            }
            x0 = j;
            double[] numsD = { };
            double xMiddle = 0;
            Console.WriteLine($"Axtardigimiz Koklerden Biri [{x0}:{x1}] Parcasinda Yerlesir");
            while ((x1 - x0) > e) 
            {
                 j = (x1 + x0) / 2;

                for (int i = 0; i < functionNum.Length; i++)
                {
                    if (i != functionNum.Length - 1)
                    {
                        double pow = Math.Pow(j, (functionNum.Length - 1 - i));
                        xMiddle += pow * functionNum[i];
                    }
                    else
                    {
                        xMiddle += functionNum[functionNum.Length - 1];
                        j++;
                    }
                }
                if (xMiddle > 0)
                {
                    x1 = j;

                }
                else if (xMiddle < 0)
                {
                    x0 = j;
                }
                Console.WriteLine($"Axtardigimiz Koklerden Biri [{x0}:{x1}] Parcasinda Yerlesir");
            }

        }
    }
}
