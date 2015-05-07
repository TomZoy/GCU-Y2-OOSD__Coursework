using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace IDisposableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyClass myObj = new MyClass())
            {
                Console.WriteLine("inside USING block");
            }
            Console.ReadLine();
        }
    }


    class MyClass : IDisposable
    {
        public MyClass()
        {
            Console.WriteLine("CREATED A NEW OBJECT WHICH MIGHT USE SYSTEM RESOURCES...");
        }
        
        
        public void Dispose()
        {
            Console.WriteLine("CLEANED UP...");
        }
    }

}
