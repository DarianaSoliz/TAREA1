using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV
{
    internal class Program
    {
    
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World");
                TV tv = new TV(600, 500, "LearnOpenTK");
                tv.Run(60.0);
            }

    
    }
}
