using System;

namespace _11.doWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            string numberAsString = Console.ReadLine();
            int n = Convert.ToInt32(numberAsString);
            int resutltFactoriel = 1;

            do
            {
                resutltFactoriel *= n;
                n--;

            } while (n > 0);

            Console.WriteLine("n! = " + resutltFactoriel);




        }
    }
}
