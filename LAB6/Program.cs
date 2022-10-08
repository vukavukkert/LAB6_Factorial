using System;
using System.Numerics;
using System.Diagnostics;

namespace LAB6
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
          while (true)
            {
             
                Console.WriteLine("Введите число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                stopWatch.Start();
                var res = Factorial(n);
                stopWatch.Stop();
                Console.WriteLine("обычный, прошло времени: " + stopWatch.Elapsed);
                stopWatch.Restart();
                var res1 = ByrecFactorial(n);
                stopWatch.Stop();
                Console.WriteLine("рекурсия, прошло времени: " + stopWatch.Elapsed);
                //Console.WriteLine(res);
                //Console.WriteLine(res1);
            }
            
        }
        static BigInteger Factorial(int x)
        {
            BigInteger result = BigInteger.One;
            for(int i = 2; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
        static BigInteger ByrecFactorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            return x * ByrecFactorial(--x);
        }
        // рекурсивный факториал имеет меньшую область значений и выполняет вычисление медленнее чем цикличный факториал. 
        // в данном случае цикличный факториал более эффективен чем рекурсивный.
        // subj для меня рекурсивный факториал выглядит более понятным чем цикличный.
    }
}