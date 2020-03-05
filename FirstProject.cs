using System;

namespace c_sharp_project       //name of project
{

    class Room {
            public double length;
            public double height;
            public double width;
    }
        

    class Program               //class
    {
        static void Main(string[] args)
        {
            //declared room1 & room2 to be instances of the Room class
            Room Room1 = new Room();
            Room Room2 = new Room();
            double total = 0.0;
            String name = "Pete";

            //room1 details
            Room1.height = 5.0;
            Room1.length = 20.0;
            Room1.width = 40.9;

            //room2 details
            Room2.height = 30.3;
            Room2.length = 12.6;
            Room2.width = 26.8;

            total = Room1.height + Room1.length + Room1.width;
            Console.WriteLine("The total is: {1} and my name is {0}", name, total);
            // Console.WriteLine("The total is: " + total + ".");
            // Console.WriteLine("Hello World!");  //console.log('Hello World')

            Console.ReadKey();      //stops the code at this point
        }
    }
}
