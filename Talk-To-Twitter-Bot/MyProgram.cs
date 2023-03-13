// The previous userInterface logic file(Program.cs) has been scattered and I think I broke the entire thing
// So now I am starting from a complete scratch now 
// I would still be going back to my Program.cs file later on; I used an if-else statement here and in the previous file(Program.cs) I made use of a switch-case statement
using System;
using System.Collections.Generic;

class MyProgram
{
    // remember we attached void to our Main() method so C# does not expect it to return any value(void returns nothing for us)
    static void Main()
    {
        Console.WriteLine("Hello There, I am Zana; A Twitter Bot made by Dynasty");
        Console.WriteLine("Would you like to Continue?");
        Console.WriteLine("Enter'Y' for Yes and 'N' to exit the Application");

        string userFirstContinue = Console.ReadLine().ToUpper();
        //    running an if-else statement branch on our Application

        if (userFirstContinue == "Y")
        {
            Console.WriteLine();
            Console.WriteLine("Before we get started, Please input your Name:");
            string myUserName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter 'C' to continue, and to Exit App; Enter 'K'");

            string myUserContinue = Console.ReadLine().ToUpper();
            Console.WriteLine();
            Console.WriteLine();

            if (myUserContinue == "C")
            {
                Console.WriteLine($"Welcome " + myUserName + ", Zana is glad to have you here");
                Console.WriteLine("Here is a list of the things I can get done for you");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1. Send a Tweet to your Twitter feed");
                Console.WriteLine("2. Display the Top Three most read Articles on Twitter for today");
                Console.WriteLine("I can also Show you the total amount of Tweets after adding a Tweet and  Delete My Tweets at anytime");


                Console.WriteLine("Having said that, let us continue");
                Console.WriteLine("To send a Tweet to your twitter feed, enter '1', to Display the Top Three most read Articles on Twitter for today, Enter '2'");

                 // reading the Line to save my User's answer and store in a string variable(NOTE: Console.WriteLine() method will read the entire Line as a string)
                        // If I wanted to work with Integer, I will still need to Parse it into an Integer later on(with the int.Parse(stringVariable) method)
                        string userAnswer = Console.ReadLine();
                        int userAnswerInt = int.Parse(userAnswer);

                        // Making up a Dictionary for Storing Tweets
                        Dictionary<int, string> tweetDictionary = new Dictionary<int, string>() { };



            }
            else if (myUserContinue == "K")
            {

            }
        }


    }
}