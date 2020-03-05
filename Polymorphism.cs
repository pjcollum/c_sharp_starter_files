using System;

namespace c_sharp_polymorphism
{
    class Program
    {

        void polyPrint(int myInteger){
            Console.WriteLine("My integer is: {0}", myInteger);
        }

        void polyPrint(double myDouble){
            Console.WriteLine("My double is: {0}", myDouble);
        }

        void polyPrint(string myString){
            Console.WriteLine("My string is: {0}", myString);
        }

        
        static void Main(string[] args)
        {
            Program myPoly = new Program();

            myPoly.polyPrint(50000);
            myPoly.polyPrint("Hello, World");
            myPoly.polyPrint(44.5);
            Console.ReadKey();

            //Console.WriteLine("Hello World!");
        }
    }
}
