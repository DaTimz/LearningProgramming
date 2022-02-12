using FirstProject.Demo;
using System;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello to you too.");
            //Program program = new Program();
            FirstClass.AddResponse(); // static
            FirstClass fs = new FirstClass();
            fs.SaySomething(); // instance

            DemoOfUsing demo = new DemoOfUsing();
            demo.SaySomething();
        }
    }
}
