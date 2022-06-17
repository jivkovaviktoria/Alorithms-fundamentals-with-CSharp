using System;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFactorial(number));
        }

        private static int GetFactorial(int number)
        {
            if (number == 0)
                return 1;

            return number * GetFactorial(number - 1);

        }
    }
}
