using System;

namespace _11.doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 11;
            
            do
            {
                i--;
                Console.WriteLine("Hi, i aways enter here at least one time" +
                    "and dont check the condition fist time");
                Console.WriteLine(i);
                
                
            } 
            while (i >= 10);   // aways is   true i >= 10; infinite cycle;




        }
    }
}
