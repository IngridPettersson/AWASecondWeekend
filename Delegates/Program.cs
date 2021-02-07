using System;

// A delegate is a type safe method pointer

namespace Delegates
{
    // This delegate, as it's written below, can point to ANY method that takes a string parameter and has a void return type.
    // More generally described, the signature of a delegate must match the method in terms of parameters and return type. This signature of the delegate also very much 
    // resembles the signature of a method. (AND note that here we are declaring the delegate, even though it looks as if we were calling it. So in that sense, I might
    // think of the delegate syntax almost as a variable syntax here, OR as the signature of an abstract method now that I've learned more :))

    public delegate void WriteMessageDelegate(string DelegateMessage);


    class Program
    {
        static void Main(string[] args)
        {

            // To make the delegate point to a specific method you must create an instance of the delegate. This is how the delegate resembles a class.

            WriteMessageDelegate del = new WriteMessageDelegate(WriteMessage); // As the argument you pass in the method that you want the delegate to point to.

            // To invoke the method now all you have to do is to invoke the delegate and give it an argument that matches, which is a string in this case.

            del("Hello from Delegate!");
            del("I can call it again!");
            del("And again and again! :)");
        }

        static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
