using System;
// "using" directive is much like require or import in Node
// lets us use the corresponding namespace (System) without needing to qualify its use when using one of its members

namespace CatWorx.BadgeMaker
// namespaces are like containers that have members
// a "member" can be another nested namespace, a method, or a class
{ 
    // everything inside these curly braces can be interpreted as members of this namespace
    // Common C# conventions are to use a company name for the root namespace in order to ensure that it is unique.
    class Program
    {
        static void Main(string[] args)
        // "main" method serves as entry point to application - invoked when program runs and where we place the code
        // in order for "main" to be recognized as entry point, the following syntax must be followed:

        // There can only be one entry point to a program
        // the keyword "void" signifies that the return of this executable method will be void
        // the keyword "static" implies that the scope of this method is on the class level, not the object level, and can thus be invoked without having to first create a new class instance. Hence the Main() method can be run as soon as the program runs.
        {
            // Console.WriteLine("Hello World!");
            string greeting = "Hello";
            greeting = greeting + "World";
            Console.WriteLine("greeting" + greeting);

        }
        // C# data types must be declared each time, unlike Javascript where just declaring var = x allows for inference of data type
        // Example:
        // JavaScript
        // var carModel = "Explorer";
        // var carPrice = 500;
        // C#
        // string carModel = "Intrepid";
        // int carPrice = 500;
    }
}
