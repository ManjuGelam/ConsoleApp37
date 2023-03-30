using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp37
{
    class Abschild:Absparent
    {
        public override void Mul (int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public override void div(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Main()
        {
            Abschild c = new Abschild();
            c.Add(100,50);
            c.sub(100,50);
            c.Mul(100,50);
            c.div(100,50);
            Console.ReadLine();
        }


    }
}
