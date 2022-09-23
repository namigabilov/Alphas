using System;

namespace SadeEdedler
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] arry = new int[0];
            Console.WriteLine("Limit daxil edin :");
            string limitStr = Console.ReadLine();
            int limit;
            while (!int.TryParse(limitStr, out limit) || limit <= 1)  
            {
                Console.WriteLine("Duzgun daxil et (min 2)");
                limitStr = Console.ReadLine();
            }
            for (int i = 2; i <= limit; i++)
            {
                Array.Resize(ref arry, arry.Length + 1);
                arry[arry.Length - 1] = i;
            }

            for (int i = 2; i < arry.Length; i++)
            {
                while (i * i < limit) 
                {
                    for (int j = 2; j < arry.Length; j++)
                    {
                        if (arry[j] % i == 0 )
                        {
                            if (arry[j]!=i)
                            {
                                arry[j] = 0;
                            }
                           
                        }
                    }
                    break;
                }
            }

            Console.Clear();

            Array.Sort(arry);
            Array.Reverse(arry);
            for (int i = arry.Length - 1; i >= 0; i--)
            {
                if (arry[i] == 0 )
                {
                    Array.Resize(ref arry , arry.Length - 1);
                }
                else
                {
                    break;
                }
            }
            Array.Reverse(arry);
            Console.WriteLine($"1-{limit} intervalinda olan sade edeler asagidakilardir :");
            Console.WriteLine(string.Join(", " , arry));
        }
       
    }
}
