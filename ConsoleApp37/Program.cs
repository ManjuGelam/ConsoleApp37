using System;
using System.Collections;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable emp = new Hashtable();
            emp.Add("emp-id", 301938);
            emp.Add("emp-name", "Manju.Gelam");
            emp.Add("emp-job", "trainee");
            emp.Add("emp-sal", 20000);
            foreach(object key in emp.Keys)
            {
                Console.WriteLine($"{key}:{emp[key]}");


            }
            Console.ReadLine();


        }
    }
}
