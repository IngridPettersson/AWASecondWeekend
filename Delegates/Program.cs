using System;

namespace Delegates
{
    // This delegate, as it's written below, can point to ANY method that takes a string parameter and has a void return type.
    // More generally described, the signature of a delegate must match the method in terms of parameters and return type.
    public delegate void WriteMessageDelegate(string DelegateMessage);

    class Program
    {
        static void Main(string[] args)
        {
            // A delegate is a type safe method pointer.
        }

        static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
