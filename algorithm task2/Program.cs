using System.Diagnostics.CodeAnalysis;

namespace algorithm_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin:");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = (int)Math.Log10(number) + 1;
            int digit;
            int sum = 0;
            

            while (number != 0)
            {
               digit = number % 10;
               number/= 10;
               sum += digit * count;
               count--;

            }
            Console.WriteLine(sum);

 
        }
    }
}