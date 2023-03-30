using System;
using System.Collections;
using System.Text;

namespace ConsoleApp37
{
     abstract class Absparent
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b); 
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public abstract void Mul(int a, int b);
        public abstract void div(int a, int b);
    }
}
