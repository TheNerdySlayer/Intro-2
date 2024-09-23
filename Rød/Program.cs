using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rød
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Console app will directly use the User input without putting it into a variable");
            Console.Write("What do you wanna say?: ");
            Console.WriteLine($"Let's see what you wrote in the previous line...: {Console.ReadLine()}");
            Console.ReadKey();
        }
    }
}
