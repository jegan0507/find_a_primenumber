using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER THE NUMBER:");
            int NUM = int.Parse(Console.ReadLine());
            int MINDIV = 2;
            int MAXDIV = (int)Math.Sqrt(NUM);
            bool PRIME = true;
            while (PRIME && MINDIV <= MAXDIV)
            {
                if (NUM % MINDIV == 0)
                {
                    PRIME = false;
                }
                MINDIV++;
            }
            Console.Write("is THE NUMBER  PRIME?"+(NUM ==1? !PRIME:PRIME));
            Console.ReadLine();
        }           
    }
}
