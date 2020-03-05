using System;

namespace c_sharp_inheritance
{
    class ObjectWeWillMessAroundWith
    {
        public void theWidth(int myWidth)
        {
            width = myWidth;
        }
        public void theHeight(int myHeight)
        {
            height = myHeight;
        }
        protected int width;
        protected int height;
    }
    class Square : ObjectWeWillMessAroundWith   //subclass created here
    {
        public int area(){
            return(width * height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Square mySquare = new Square();     //creates new instance of square class
            mySquare.theHeight(10);             //height = 10
            mySquare.theWidth(10);              //width = 10
            Console.WriteLine("My square has a value of: {0}", mySquare.area());    //10 * 10
            Console.ReadKey();

            Console.WriteLine("Hello World!");
        }
    }
}
