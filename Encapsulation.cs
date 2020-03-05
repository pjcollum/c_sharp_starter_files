using System;

namespace c_sharp_encapsulation
{
    class AreaClass
    {
        public double width;
        public double length;
        public double age = 27;
        public string userInput;
        public double Area()
        {
            return width * length;
        }

        public void InformationDisplayed()
        {
            Console.WriteLine("width = {0}", width);
            Console.WriteLine("length = {0}", length);
            Console.WriteLine("Our area is {0}", Area());
        }
        public void UserDetails()
        {

            double myDouble = 44.0;
            int myInt = 44;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myDouble));      //converts double data type to a string
            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToString(myBool));

                Console.WriteLine("Please enter your user details: ");
                userInput = Console.ReadLine();
                if (Convert.ToDouble(userInput) == age)
                {
                    Console.WriteLine("Woah, it matches");
                }
        }
    }
    class Program
    {


        static void Main(string[] args)
        {

            AreaClass myShape = new AreaClass();
            myShape.width = 12.94;
            myShape.length = 6.87;
            myShape.InformationDisplayed();
            myShape.UserDetails();
            Console.ReadKey();
        }
    }
}
