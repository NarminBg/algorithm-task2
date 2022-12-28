namespace algorithm_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin:");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0, r, place = 1;
            place = number.ToString().Length;


            while (number != 0)
            {
                r = number % 10;
                sum += r * place;
                place--;
                number /= 10;



            }
            Console.WriteLine(sum.ToString());
        }
    }
}