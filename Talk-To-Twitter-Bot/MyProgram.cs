// I used if-else statements to achieve my goals in this App

// The previous userInterface logic file(Program.cs) has been scattered and I think I broke the entire thing
// So now I am starting from a complete scratch now 
// I would still be going back to my Program.cs file later on; I used an if-else statement here and in the previous file(Program.cs) I made use of a switch-case statement
using System;
using System.Collections.Generic; // don't forget this line was written so C# givs us the permissiogrl
using System.Linq; // with the System.Linq, my application  understands what the .ElementAt() method I called on my dictionary is doing

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
            Console.WriteLine("Before we get started, Please enter your Name:");
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
                string myUserAnswer = Console.ReadLine();
                int myUserAnswerInt = int.Parse(myUserAnswer);

                // Making up a Dictionary for Storing Tweets
                Dictionary<int, string> tweetDictionary = new Dictionary<int, string>() { };

                if (myUserAnswerInt == 1)
                {
                    Console.WriteLine($"Dear {myUserName}, Enter the Tweet you want to add to your Timeline");
                    string myUserFirstTweet = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine();

                    tweetDictionary.Add(1, myUserFirstTweet);

                    Console.WriteLine("Tweet has been successfully added to your Twiter feed");

                    Console.WriteLine();

                    Console.WriteLine("You can carry out other tasks with the help of Zana, other tasks like Deleting any Tweet, Seeing the entire Tweets on your Timeline, and adding more Tweets");
                    Console.WriteLine("NOTE: To add in a more tweets Enter'Y', to see all Tweets on Timeline enter 'S', To delete tweets, simply enter 'D'");
                    string myUserAnswer2 = Console.ReadLine().ToUpper();

                    if (myUserAnswer2 == "Y")
                    {
                        Console.WriteLine("What is the next Tweet you want to add");
                        string myUserSecondTweet = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        tweetDictionary.Add(2, myUserSecondTweet);

                        Console.WriteLine("Tweet has been successfully added to your Twiter feed");
                        Console.WriteLine();

                        Console.WriteLine("NOTE: To add in more tweets Enter'Y', to see all Tweets on Timeline enter 'S', To delete tweets, simply enter 'D'");
                        string myUserAnswer3 = Console.ReadLine().ToUpper();

                        if (myUserAnswer3 == "Y")
                        {

                        }
                        else if (myUserAnswer3 == "N")
                        {
                            Console.WriteLine($"Goodbye {myUserName}");
                        }
                        else if (myUserAnswer3 == "S")
                        {
                            Console.WriteLine($"Here are all the Tweets Present in {myUserName}'s Timeline");

                            for (int index = 0; index < tweetDictionary.Count; index++)
                            {
                                KeyValuePair<int, string> forEveryTweet = tweetDictionary.ElementAt(index);
                                Console.WriteLine($"{myUserName} added the Tweet: '{forEveryTweet.Value}', Zana says it was your number {forEveryTweet.Key} Tweet");

                            }

                            Console.WriteLine($"{myUserName} You have seen all the Tweets, Enter 'G' If you would like to go back to Main Menu or Enter 'C' to exit Application");

                            string userContinueAfterSeeingSecondTweet = Console.ReadLine().ToUpper();

                            if (userContinueAfterSeeingSecondTweet == "G")
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Main();
                            }
                            else if (userContinueAfterSeeingSecondTweet == "C")
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine($"Goodbye {myUserName}");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine($"Sorry {myUserName}, Zana didn't get that");
                                Main();
                            }

                        }
                        else if (myUserAnswer3 == "D")
                        {

                        }


                    }

                    else if (myUserAnswer2 == "N")
                    {
                        Console.WriteLine($"Goodbye {myUserName}");
                    }


                    else if (myUserAnswer2 == "S")
                    {
                        // The Seeing Feature that lets you see all Tweets Present on your Timeline
                        Console.WriteLine($"Here are all the Tweets Present in {myUserName}'s Timeline");
                        // a forloop to help display each Item I stored in my tweetDictionary
                        // using the .Count property that works with Lists and Dictionaries(and it helps to count each index Present n a Dictionary or a List)
                        for (int index = 0; index < tweetDictionary.Count; index++)
                        {
                            // Working with the KeyValuePair object to ensure my looping works
                            // And at the top I have added a using System.Linq(and this will make me able to use the .ElementAt() methodt that is very keen when working with forloop's)
                            KeyValuePair<int, string> forEveryTweet = tweetDictionary.ElementAt(index);
                            Console.WriteLine($"{myUserName} added the Tweet: '{forEveryTweet.Value}', Zana says it was your number {forEveryTweet.Key} Tweet");

                        }

                        Console.WriteLine($"{myUserName} You have seen all the Tweets, Enter 'G' If you would like to go back to Main Menu or Enter 'C' to exit Application");

                        string userContinueAfterSeeingFirstTweet = Console.ReadLine().ToUpper();

                        if (userContinueAfterSeeingFirstTweet == "G")
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            // Calling my Main() method entry-point that takes my user to the start of my Application
                            Main();
                        }
                        else if (userContinueAfterSeeingFirstTweet == "C")
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine($"Goodbye {myUserName}");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine($"Sorry {myUserName}, Zana didn't get that");
                            Main();
                        }


                    }

                    else if (myUserAnswer2 == "D")
                    {
                        // This is the delete feature; Here I would be needing my looping also because I would be showing my users the left over value
                        for (int index = 0; index < tweetDictionary.Count; index++)
                        {
                            // Working with the KeyValuePair object to ensure my looping workds
                            // And at the top I have added a using System.Linq(and this will make me able to use the .ElementAt() methodt that is very keen when working with forloop's)
                            // The .ElementAt() is a method and only parenthesis should be added to it and not square brackets
                            KeyValuePair<int, string> forEveryTweet = tweetDictionary.ElementAt(index);
                            Console.WriteLine($"{myUserName} added the Tweet: '{forEveryTweet.Value}', Zana says it was your number {forEveryTweet.Key} Tweet");

                        }

                        Console.WriteLine("Enter the Tweet Number you want to delete");
                        string deleteTweetFirstTime = Console.ReadLine();
                        int deleteTweetFirstTimeInt = int.Parse(deleteTweetFirstTime);

                        tweetDictionary.Remove(deleteTweetFirstTimeInt);
                        Console.WriteLine($"The Tweet with Number {deleteTweetFirstTimeInt} has been deleted");

                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine($"{myUserName} There are no more Tweets, Enter 'G' If you would like to go back to Main Menu or Enter 'C' to exit Application");

                        string userContinueAfterDeletingFirstTweet = Console.ReadLine().ToUpper();

                        if (userContinueAfterDeletingFirstTweet == "G")
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            // Calling my Main() method entry-point that takes my user to the start of my Application
                            Main();
                        }
                        else if (userContinueAfterDeletingFirstTweet == "C")
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine($"Goodbye {myUserName}");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine($"Sorry {myUserName}, Zana didn't get that");
                            Main();
                        }

                    }


                }

            }
            else if (myUserContinue == "K")
            {
                Console.WriteLine($"Goodbye {myUserName}");

            }
        }


    }
}