using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_SoftwareArch_Console
{
    class Program
    {

        // echos the user's name and prints a randomly chosen int:
        static void Main(string[] args)
        {
            // how to generate random numbers:
            Random r = new Random();
            int min = 0;
            int max = 10;
            
            int m;
            do
            {
                Console.WriteLine("Guess an int, M, in range {0} to {1}: M =", min, max);
                string s = Console.ReadLine();
                m = Int32.Parse(s);
                if(m <0 || m > 10)
                {
                    Console.WriteLine("Invalid Enter!");
                }
            } while (m < 0 || m > 10);

            Console.WriteLine("I guess int, N, in range {0}, {1}-M", min, max);
            int n = r.Next(min, max - m + 1);
            //Console.WriteLine("Here is a random generated number between {0} to {1}: {2}", min, max, n);
            Console.WriteLine("now you type an int, P, such that M + N + P = 10: P =");
            string str = Console.ReadLine();
            int p = Int32.Parse(str);
            if((m + n + p) == 10)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
            // retain command window till user presses Enter
            Console.ReadLine();
        }
    }
}
