using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp123
{
    public delegate int nudel(int x);
    class ExtensionMethod
    {
       public int Sum()
        {
            int a = 10;
            int b = 2;
            int c = a + b;
            return c;
        }
        public int Sub()
        {
            int a = 10;
            int b = 2;
            int c = a - b;
            return c;
        }
        public int Mul()
        {
            int a = 10;
            int b = 2;
            int c = a * b;
            return c;
        }
    }
}
