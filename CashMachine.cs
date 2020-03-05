using System;

namespace c_sharp_cash_machine
{
    class Program
    {

        void withdraw(int bankBalance, int withdrawAmount)
        {
            bankBalance -= withdrawAmount;
            Console.WriteLine("My new balance is: {0}", bankBalance);
        }

        void checkPin()
        {
            START:
              // taking user input
            string pinNumber = "1000";
            string userInput;
            Console.Write("Please enter your input: ");
            userInput = Console.ReadLine();

            //Console.WriteLine(userInput);   //print userInput on this line

            if(userInput == pinNumber){
                Console.WriteLine("Pin Number is correct");
            } else{
                Console.WriteLine("Incorrect Pin Number");
                goto START;
            }
        }
        static void Main(string[] args)
        {
            Program cashMachine = new Program();
            cashMachine.withdraw(500, 30);

            cashMachine.checkPin();
        }
    }
}
