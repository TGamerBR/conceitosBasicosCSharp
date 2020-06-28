using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitosBásicos
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int val1 = 32;
            int result;
            result = 10 + val1++; Console.WriteLine(result);
            result = 10 + ++val1;Console.WriteLine(result);
            Console.ReadLine();
            
        }
    }
}
