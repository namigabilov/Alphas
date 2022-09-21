using System;

namespace EKOB_EBOB_LIMIT_TOREME_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            #region EBOB,EKOB
            Console.WriteLine("Eded 1 i daxil edin : ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Eded 2 ni daxil edin :");
            double num2 = double.Parse(Console.ReadLine());
            if (EKOB(num1, num2) == num1 * num2)
            {
               Console.WriteLine("Ededler qarsiliqli sadedir ");
            }
            Console.WriteLine($"EKOB = {EKOB(num1, num2)}");
            if (EBOB(num1, num2) == 1)
            {
               Console.WriteLine("Ededler qarsiliqli sadedir ");
            }
            Console.WriteLine($"EKOB = {EBOB(num1, num2)}");
            #endregion
            do
            {
                Console.WriteLine("X^2 funksiyasinin toremesinin 0.0000000001 deqiqlikle hesablayaq : \nEdedi daxil edin:");
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine(Diferecial(num));
                Console.WriteLine($"Dayandirmaq ucun  'STOP'  yazib enter edin , eks halda enter basin");
                string stop = Console.ReadLine();
                stop = stop.Trim();
                if (stop == "STOP")
                {
                    check = false;
                }
            } while (check);

        }

        static double EKOB(double num1 , double num2)
        {
            double  min = 0, max = 0;
            if (num1 > num2 )
            {
                min = num2;
                max = num1;
            }
            else
            {
                max = num2;
                min = num1;
            }

            for (double i = min; ; i++)
            {
                if (i % num2 == 0  && i % num1 ==0)
                {
                    return i;
                   
                }
            }
        }
        static double EBOB(double num1 , double num2)
        {
            double min = 0, max = 0;
            if (num1 > num2)
            {
                min = num2;
                max = num1;
            }
            else
            {
                max = num2;
                min = num1;
            }

            for (double i = max; i > 0; i--)
            {
                if (num1 % i == 0 && num2 % i == 0) 
                {
                    return i;
                }
                else if (i == 1)
                {
                    return 1;
                }
            }
            return -1;
        }
        static double Diferecial(double num )
        {
            //result alinan neticedir 
            double result = 0;
            // m modul x dir 
            double m = 0.1;
            // default olaraq funksiyamizi x^2 olaraq gotururuk 
            //double sum = num + m;
            while (m > 0.0000000001) 
            {
                m /= 10;
                result =( Math.Pow((num + m) , 2) - num*num) / m;
            }
            return result;
//What is my branche
            
        }
         
    }
}
