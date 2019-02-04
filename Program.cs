using System;

namespace Multiples_of_fifty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two numbers");
            int maxnumber=int.Parse(Console.ReadLine());
            int minnumber=int.Parse(Console.ReadLine());
            for (int i = maxnumber; i>minnumber; i--)
            {
                if ((i%50)==0)
                {
               Console.WriteLine(i);
                   
                }
             //break;
            }
        }
    }
}
