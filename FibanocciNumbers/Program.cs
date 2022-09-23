using System;

namespace FibanocciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1,1,2,3,5,8,13,21,34
            int[] arry = new int[0]; 
            Console.WriteLine("fibanocci sayi daxil edin :");
            string limitStr = Console.ReadLine();
            int limit;
            while (!int.TryParse(limitStr , out limit))
            {
                Console.WriteLine("Duzgun daxil et reqem olmalidir ");
                limitStr = Console.ReadLine();
            }
            
            int fib1 = 1, fib2 = 1;
            int i = 3;
            while (true)  
            {
                Array.Resize(ref arry , arry.Length + 2);
                arry[arry.Length - 2] = fib1;
                arry[arry.Length - 1] = fib2;
                fib1 = fib1 + fib2;
                fib2 = fib2 + fib1;
                if (i>limit)
                {
                    break;
                }
                i+=2;
                
            }
            Console.WriteLine(string.Join(", ", arry));

        }
    }
}
