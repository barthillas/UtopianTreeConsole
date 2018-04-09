using System;

namespace UtopianTreeConsole
{
    class Program
    {

        static int utopianTree(int n) {


             int x = 1;
            if (n % 2 == 0)
            {

                int seasons = n / 2;
                for (int i = seasons; i > 0; i--)
                {
                    x = 2 * x;
                    x++;


                }
                return x;
            }

            else
            {
                int seasons = (n+1) / 2;
                for (int i = seasons; i > 0; i--)
                {
                    x = 2 * x;

                    x++;

                }

                x--;

               
                return x;
            }

         







        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many different input tests do you wish to try?");
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {

                Console.WriteLine("How many seasons do you wish to proceed?");
                Console.WriteLine("");

               int n = Convert.ToInt32(Console.ReadLine());
                int result = utopianTree(n);
                
                Console.WriteLine("Your result:"+result);
            }
        }
    }
}
