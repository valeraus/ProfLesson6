using System;
using System.Reflection;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load("Task_2");

            dynamic instance = Activator.CreateInstance(assembly.GetType("Task_2.Temperature"));

            Console.WriteLine("15 °C по °F равно " + instance.Fahrenheit(15m));

            Console.ReadKey();
        }
    }
}
