using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; //storing a double in an object
            object name = "Amir";  //storing a string in an object

            Console.WriteLine($"{name} is {height} metres tall.");

            //int length1 = name.Length;
            int length2 = ((string)name).Length;  //tell the compiler it is a string

            Console.WriteLine($"{name} has {length2} characters");

            //storing a string in a dynamic object
            dynamic anotherName = "ahmed";

            //this compiles but would throw an exception at run-time if you later store a data type that does not have a property named length
            int length = anotherName.Length;

            var population = 66_000_000; //66 million in the UK
            var weight = 1.88;  //in kilograms
            var price = 4.99M;  //in poupnds sterling
            var fruit = "Apples";   ///strings 
            var letter = 'Z';
            var happy = true;


            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(datetime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");
        }
    }
}
