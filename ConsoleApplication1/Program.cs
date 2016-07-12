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
            
            string s = "AFRTSSDJJJ";
            foreach (char c in s)
            {
                if (c == 'T')
                {
                    continue;
                }
                else if(c == 'D')
                {
                    break;
                }

                Console.WriteLine(c);

            }
            Console.Read();

        }
    }
}
