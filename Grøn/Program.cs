using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grøn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myText = "Hello World!";
            Console.WriteLine(myText);
            Console.Write("What's your name?: ");
            string myName = Console.ReadLine();
            Console.WriteLine($"Hello {myName}");
            Console.ReadKey();

            // ReadKey will read what key you pressed while ReadLine will read the previous Console.Write commandsinput from the user.
        }
    }
}
