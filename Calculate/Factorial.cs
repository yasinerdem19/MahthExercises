using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercises.Calculate
{
    internal class Factorial
    {
        public static void FactorialForImputValue()
        {
            Console.Write("Faktöriyel Hesabı için sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = 2; i < n; i++)
            {
                f *= i;
            }
            Console.WriteLine("{0}! = {1}",n,f);
        }
        public static int FactorialForSentValue(int n)
        {
            if (n<=1)
            {
                return 1;
            }
            return n * FactorialForSentValue(n - 1);
        }
    }
}
