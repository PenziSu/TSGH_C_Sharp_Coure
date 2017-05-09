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
            //Nullable
            int? x = null;
            if (true)
            {
                x = 0;
            }
            Console.WriteLine(x);
        }
    }
}
