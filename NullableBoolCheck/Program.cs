using System;

namespace NullableBoolCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? nullableBool = null;
            Console.WriteLine(nullableBool == false ? "Wierd!" : "Logical!");
            Console.ReadKey();
        }
    }
}
