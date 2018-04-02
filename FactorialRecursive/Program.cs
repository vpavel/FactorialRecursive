using System;

namespace FactorialRecursive
{
    class Factorial {
        public int getFactorial(int n)
        {
            if (n == 0)
                return 1;
            return n * getFactorial(n - 1);
        }
        static void Main(string[] args)
        {
            Factorial fac = new Factorial();
            Console.WriteLine("factorial of 5 is: {0}", fac.getFactorial(5));
            Console.WriteLine("factorial of 6 is: {0}", fac.getFactorial(6));
            Console.ReadLine();
        }
    }
}

