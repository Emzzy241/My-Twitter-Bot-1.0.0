// I used switch-case statements to achieve my goals in this App
// THis is not the Final version for the Bot App
// Here are a few things I hope to inculcate into this App in other Future Versions
// * Bot must be able to:
// * Track a major newspaper's articles and tweet when changes are made to articles.
// * Tweet when Bitcoin moves up or down 5%in the last hour.
// * Retweet every tweet that mentions a specific hashtag
// * Reply to Questions sent to you with an answer from another APi
// * Create a timer bot that responsds to every time interval sent to it with a reply when that time interval is up
// And many more amazing features

/*
using System;
using System.Collections.Generic;
using System.Linq;
// I made use of System.Collections.Generic class to ensure my app can work with Dictionaries
// I made use of the System namespace so my Application can understand C# classes like the String class, the Console class, int class, double class e.t.c
// made use of the System,Linq class so My application can understand my .ElementAt() method which is capable of
class Program
{
    static void Main()
    {
        //  After writing my Project file, I had an error running(dotnet run) until I added my Main() method which is the Entry point for C#


        Console.WriteLine("Hello There, I am Zana; A Twitter Bot made by Dynasty");
        Console.WriteLine("Would you like to Continue?");
        Console.WriteLine("Enter'Y' for Yes and 'N' to exit the Application");
        // Determining what my User wants to do
        string userDo = Console.ReadLine().ToUpper();
        switch (userDo)
        {
            case "Y":

                Console.WriteLine();
                Console.WriteLine("Before we get started, Please input your Name:");
                string userName = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Enter 'C' to continue, and to Exit App; Enter 'K'");

                string userContinue = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.WriteLine();

                switch (userContinue)
                {
                    case "C":
                        Console.WriteLine($"Welcome " + userName + ", Zana is glad to have you here");
                        Console.WriteLine("Here is a list of the things I can get done for you");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("1. Send a Tweet to your Twitter feed");
                        Console.WriteLine("2. Display the Top Three most read Articles on Twitter for today");
                        Console.WriteLine("3. Show you the total amount of Tweets after adding a Tweet");
                        Console.WriteLine("4. Delete My Tweets at anytime");

                        Console.WriteLine("Having said that, let us continue");
                        Console.WriteLine("To send a Tweet to your twitter feed, enter '1', to Display the Top Three most read Articles on Twitter for today, Enter '2'");

                        // reading the Line to save my User's answer and store in a string variable(NOTE: Console.WriteLine() method will read the entire Line as a string)
                        // If I wanted to work with Integer, I will still need to Parse it into an Integer later on(with the int.Parse(stringVariable) method)
                        string userAnswer = Console.ReadLine();
                        int userAnswerInt = int.Parse(userAnswer);

                        // working with switch-case statements instead of an if-statement branching

                        // Making up a Dictionary for Storing Tweets
                        Dictionary<int, string> tweetDictionary = new Dictionary<int, string>() { };

                        switch (userAnswerInt)
                        {
                            case 1:
                                Console.WriteLine("You enterred '1' for Tweet; Enter the Tweet you want to Add to your Feed");

                                string userTweet1 = Console.ReadLine();
                                tweetDictionary.Add(1, userTweet1);
                                Console.WriteLine();
                                Console.WriteLine();

                                Console.WriteLine("Tweet has been successfully added to your Twiter feed");


                                Console.WriteLine("Would you like to upload another Tweet? Enter 'Y' for Yes and 'N' for No.");
                                Console.WriteLine("To Delete any Tweet, Enter 'D' to delete any Tweet of your choice. To See all Tweets on your Timeline, enter 'S'");

                                string userAction1 = Console.ReadLine().ToUpper();

                                switch (userAction1)
                                {
                                    // If user inputs in an Y for a Yes ====> FOR 2ND TWEET
                                    case "Y":
                                        Console.WriteLine("You enterred 'Y' for a Yes to upload another Tweet; Enter the Tweet you want to Add to your Feed");

                                        string userTweet2 = Console.ReadLine();
                                        tweetDictionary.Add(2, userTweet2);
                                        Console.WriteLine();
                                        Console.WriteLine();

                                        Console.WriteLine("Tweet has been successfully added to your Twiter feed");



                                        Console.WriteLine("Would you like to upload another Tweet? Enter 'Y' for Yes and 'N' for No");
                                        Console.WriteLine("To Delete any Tweet, Enter 'D' to delete any Tweet of your choice. To See all Tweets on your Timeline, enter 'S'");

                                        string userAction2 = Console.ReadLine().ToUpper();

                                        // using a switch-case statement for the second Action User wants to perform

                                        switch (userAction2)
                                        {
                                            case "Y":
                                                Console.WriteLine("You enterred 'Y' for a Yes to upload a Tweet; Enter the Tweet you want to Add to your Feed");

                                                string userTweet3 = Console.ReadLine();
                                                tweetDictionary.Add(3, userTweet3);
                                                Console.WriteLine();
                                                Console.WriteLine();

                                                Console.WriteLine("Tweet has been successfully added to your Twiter feed");

                                                Console.WriteLine("Would you like to upload another Tweet? Enter 'Y' for Yes and 'N' for No");
                                                Console.WriteLine("To Delete any Tweet, Enter 'D' to delete any Tweet of your choice. To See all Tweets on your Timeline, enter 'S'");

                                                string userAction3 = Console.ReadLine().ToUpper();

                                                switch (userAction3)
                                                {
                                                    case "Y":
                                                        Console.WriteLine("You enterred 'Y' for a Yes to upload a Tweet; Enter the Tweet you want to Add to your Feed");

                                                        string userTweet4 = Console.ReadLine();
                                                        tweetDictionary.Add(4, userTweet4);
                                                        Console.WriteLine();
                                                        Console.WriteLine();

                                                        Console.WriteLine("Tweet has been successfully added to your Twiter feed");

                                                        Console.WriteLine("Would you like to upload another Tweet? Enter 'Y' for Yes and 'N' for No");
                                                        Console.WriteLine("To Delete any Tweet, Enter 'D' to delete any Tweet of your choice. To See all Tweets on your Timeline, enter 'S'");

                                                        string userAction4 = Console.ReadLine().ToUpper();

                                                        switch (userAction4)
                                                        {
                                                            case "Y":
                                                                Console.WriteLine("You enterred 'Y' for a Yes to upload a Tweet; Enter the Tweet you want to Add to your Feed");

                                                                string userTweet5 = Console.ReadLine();
                                                                tweetDictionary.Add(5, userTweet5);
                                                                Console.WriteLine();
                                                                Console.WriteLine();

                                                                Console.WriteLine("Tweet has been successfully added to your Twiter feed");
                                                                break;
                                                            case "N":
                                                                break;

                                                            case "S":
                                                                break;

                                                            case "D":

                                                                Console.WriteLine("Enter the Tweet Number you will like to delete");
                                                                string deleteSecondTweetAfter3 = Console.ReadLine();
                                                                int deleteSecondTweetAfter3Int = int.Parse(deleteSecondTweetAfter3);
                                                                tweetDictionary.Remove(deleteSecondTweetAfter3Int);


                                                                Console.WriteLine();
                                                                Console.WriteLine();
                                                                Console.WriteLine("All Tweets have been Deleted");
                                                                Console.WriteLine("Enter 'C' to go back to Main Menu or 'K' to Exit Application");
                                                                string userContinuesAfterDeletingLastTweet2 = Console.ReadLine().ToUpper();
                                                                switch (userContinuesAfterDeletingLastTweet2)
                                                                {
                                                                    case "C":
                                                                        Main();
                                                                        break;
                                                                    case "K":
                                                                        Console.Write($"Goodbye {userName}");
                                                                        break;

                                                                    default:
                                                                        Console.WriteLine($"Dear {userName} Zana didn't get that, Please Try again");
                                                                        Main();
                                                                        break;
                                                                }
                                                                break;

                                                            case "M":
                                                                Main();
                                                                break;

                                                            case "Q":
                                                                Console.WriteLine($"Goodbye {userName}");
                                                                break;

                                                            default:
                                                                Console.WriteLine($"Dear {userName} Zana didn't get that, Please Try again");
                                                                Main();
                                                                break;
                                                        }

                                                        break;

                                                    case "N":
                                                        Console.WriteLine("You enterred 'N' for a No to upload a Tweet; Enter the Tweet you want to Add to your Feed");
                                                        Console.WriteLine($"Goodbye {userName}");
                                                        break;

                                                    case "S":
                                                        Console.WriteLine("Here are all the Tweets you have");
                                                        // using a foreach loop here to show my user the remaining Tweets
                                                        foreach (KeyValuePair<int, string> eachRemainingTweet in tweetDictionary)
                                                        {
                                                            Console.WriteLine($"You added the Tweet: '{eachRemainingTweet.Value}', Zana says it was your number {eachRemainingTweet.Key} Tweet");

                                                        }
                                                        break;

                                                    //     case "D":

                                                    //         Console.WriteLine("Enter the Tweet Number you will like to delete");
                                                    //         string deleteSecondTweetAfter2 = Console.ReadLine();
                                                    //         int deleteSecondTweetAfter2Int = int.Parse(deleteSecondTweetAfter2);
                                                    //         tweetDictionary.Remove(deleteSecondTweetAfter2Int);


                                                    //         Console.WriteLine();
                                                    //         Console.WriteLine();
                                                    //         Console.WriteLine("All Tweets have been Deleted");
                                                    //         Console.WriteLine("Enter 'C' to go back to Main Menu or 'K' to Exit Application");
                                                    //         string userContinuesAfterDeletingLastTweet = Console.ReadLine().ToUpper();
                                                    //         switch (userContinuesAfterDeletingLastTweet)
                                                    //         {
                                                    //             case "C":
                                                    //                 Main();
                                                    //                 break;
                                                    //             case "K":
                                                    //                 Console.Write($"Goodbye {userName}");
                                                    //                 break;

                                                    //             default:
                                                    //                 Console.WriteLine($"Dear {userName} Zana didn't get that, Please Try again");
                                                    //                 Main();
                                                    //                 break;
                                                    //         }
                                                    //         break;

                                                    //     case "M":
                                                    //         Main();
                                                    //         break;

                                                    //     case "Q":
                                                    //         Console.WriteLine($"Goodbye {userName}");
                                                    //         break;

                                                    //     default:
                                                    //         Console.WriteLine($"Dear {userName} Zana didn't get that, Please Try again");
                                                    //         Main();
                                                    //         break;
                                                    // }
                                                    // break;



                                                    case "D":
                                                        Console.WriteLine();
                                                        Console.WriteLine();
                                                        Console.WriteLine($"Total Tweets on {userName}'s Feed are: ");
                                                        // A forloop on my tweetDictionary that displays all Tweets
                                                        // using the .Count property that works with Lists and Dictionaries(and it helps to count each index Present n a Dictionary or a List)
                                                        for (int i = 0; i < tweetDictionary.Count; i++)
                                                        {
                                                            KeyValuePair<int, string> eachTweet = tweetDictionary.ElementAt(i);
                                                            Console.WriteLine($"You added the Tweet: '{eachTweet.Value}', Zana says it was your number {eachTweet.Key} Tweet");

                                                        }
                                                        Console.WriteLine();
                                                        Console.WriteLine();
                                                        Console.WriteLine("Enter the tweet Number you would like to delete");
                                                        string deleteTweet2 = Console.ReadLine();
                                                        // My Dictionary's key is in integers, I need to convert the string COnsole.ReadLine() gives me to integers
                                                        int deleteTweet2Int = int.Parse(deleteTweet2);
                                                        tweetDictionary.Remove(deleteTweet2Int);
                                                        Console.WriteLine($"Tweet with Number {deleteTweet2Int} has been deleted");

                                                        Console.WriteLine();
                                                        Console.WriteLine("Enter 'C' to continue or 'k' to go back to Zana's Main Menu");
                                                        string afterDeletingTweetContinue2 = Console.ReadLine().ToUpper();
                                                        switch (afterDeletingTweetContinue2)
                                                        {
                                                            case "C":
                                                                // a forloop listing out the remaining Tweets(1) for my user after one of the two present tweets must have been deleted
                                                                Console.WriteLine($"{userName}, Here are the remaining Tweets on your Timeline, Enter 'D' to delete another Tweet, Enter 'M' to go back to Main Menu, or Enter 'Q' to Quit Application");

                                                                for (int i = 0; i < tweetDictionary.Count; i++)
                                                                {
                                                                    KeyValuePair<int, string> eachTweet = tweetDictionary.ElementAt(i);
                                                                    Console.WriteLine($"You added the Tweet: '{eachTweet.Value}', Zana says it was your number {eachTweet.Key} Tweet");

                                                                }

                                                                // I used foreach loop to show user's each remaining Tweet; you can also use a forloop only if you want to

                                                                string afterUserDeletesTweet2 = Console.ReadLine().ToUpper();

                                                                switch (afterUserDeletesTweet2)
                                                                {
                                                                    case "D":
                                                                        Console.WriteLine("Enter the Tweet Number you will like to delete");
                                                                        string deleteSecondTweetAfter1 = Console.ReadLine();
                                                                        int deleteSecondTweetAfter1Int = int.Parse(deleteSecondTweetAfter1);
                                                                        tweetDictionary.Remove(deleteSecondTweetAfter1Int);


                                                                        Console.WriteLine();
                                                                        Console.WriteLine();
                                                                        Console.WriteLine("All Tweets have been Deleted");
                                                                        Console.WriteLine("Enter 'C' to go back to Main Menu or 'K' to Exit Application");
                                                                        string userContinuesAfterDeletingLastTweet = Console.ReadLine().ToUpper();
                                                                        switch (userContinuesAfterDeletingLastTweet)
                                                                        {
                                                                            case "C":
                                                                                Main();
                                                                                break;
                                                                            case "K":
                                                                                Console.Write($"Goodbye {userName}");
                                                                                break;

                                                                            default:
                                                                                Console.WriteLine($"Dear {userName} Zana didn't get that, Please Try again");
                                                                                Main();
                                                                                break;
                                                                        }
                                                                        break;

                                                                    case "M":
                                                                        Main();
                                                                        break;

                                                                    case "Q":
                                                                        Console.WriteLine($"Goodbye {userName}");
                                                                        break;

                                                                    default:
                                                                        Console.WriteLine($"Dear {userName} Zana didn't get that, Please Try again");
                                                                        Main();
                                                                        break;
                                                                }

                                                                // Console.WriteLine("Would you like to Delete another Tweet?");
                                                                // Console.WriteLine("Enter 'Y' for a Yes and 'N' for a No");

                                                                // string afterDeletingTweetContinue2 = Console.ReadLine();

                                                                // switch (afterDeletingTweetContinue2)
                                                                // {
                                                                //     case "Y":
                                                                //         Console.WriteLine("Input the Tweet Number you would like to delete");
                                                                //         string deleteTweet2 = Console.ReadLine();
                                                                //         int deleteTweet2Int = int.Parse(deleteTweet2);
                                                                //         tweetDictionary.Remove(deleteTweet2Int);
                                                                //         break;

                                                                //     default:
                                                                //     break;
                                                                // }

                                                                break;
                                                            case "K":
                                                                Console.WriteLine("Going to the Main Menu..........");
                                                                Main();
                                                                break;

                                                            default:
                                                                Console.WriteLine($"Dear {userName} Zana didn't get that, Please Try again");
                                                                Main();
                                                                break;
                                                        }
                                                        break;

                                                        case "D":
                                                                        Console.WriteLine("Enter the Tweet Number you will like to delete");
                                                                        string deleteSecondTweetAfter2 = Console.ReadLine();
                                                                        int deleteSecondTweetAfter2Int = int.Parse(deleteSecondTweetAfter1);
                                                                        tweetDictionary.Remove(deleteSecondTweetAfter2Int);


                                                                        Console.WriteLine();
                                                                        Console.WriteLine();
                                                                        Console.WriteLine("All Tweets have been Deleted");
                                                                        Console.WriteLine("Enter 'C' to go back to Main Menu or 'K' to Exit Application");
                                                                        string userContinuesAfterDeletingLastTweet = Console.ReadLine().ToUpper();
                                                                        switch (userContinuesAfterDeletingLastTweet)
                                                                        {
                                                                            case "C":
                                                                                Main();
                                                                                break;
                                                                            case "K":
                                                                                Console.Write($"Goodbye {userName}");
                                                                                break;

                                                                            default:
                                                                                Console.WriteLine($"Dear {userName} Zana didn't get that, Please Try again");
                                                                                Main();
                                                                                break;
                                                                        }
                                                                        break;


                                                    default:
                                                        Console.WriteLine($"Dear {userName} Zana didn't get that, Please Try again");
                                                        Main();
                                                        break;
                                                }

                                                break;













                                            // For the Deleting tweet; since user has added in 2 tweets, they can now delete 2 tweets



                                            default:

                                                Console.WriteLine($"Dear {userName} Zana didn't get that, Please Try again");
                                                Main();
                                                break;

                                        }

                                    break;
                                }

                                break;

                            // If user inputs in an N for a No
                            case 2:
                                Console.WriteLine("Here are the Top 3 most read Articles for Today");

                                // Later on I would be adding a randomizer that would be helping randomize all these tweets everytime user runs application again

                                Console.WriteLine("1. Harry Potter the mighty Wizardry");
                                Console.WriteLine("2. A Boy named Dynasty has built the next Unicorn");
                                Console.WriteLine("3. Chris Rock slaps Will Smith's Wife");
                                break;

                                // If user inputs in an D to Delete Any of User's Tweet

                                //                     case 3:
                                //                         Console.WriteLine();
                                //                         Console.WriteLine();
                                //                         Console.WriteLine($"Total Tweets on {userName}'s Feed are: ");
                                //                         // A forloop on my tweetDictionary that displays all Tweets
                                //                         // using the .Count property that works with Lists and Dictionaries(and it helps to count each index Present n a Dictionary or a List)
                                //                         for (int i = 0; i < tweetDictionary.Count; i++)
                                //                         {
                                //                             KeyValuePair<int, string> eachTweet = tweetDictionary.ElementAt(i);
                                //                             Console.WriteLine($"You added the Tweet: '{eachTweet.Value}', Zana says it was your number {eachTweet.Key} Tweet");

                                //                         }
                                //                         Console.WriteLine();
                                //                         Console.WriteLine();
                                //                         Console.WriteLine("Enter the tweet Number you would like to delete");
                                //                         string deleteTweet1 = Console.ReadLine();
                                //                         // My Dictionary's key is in integers, I need to convert the string Console.ReadLine() gives me to integers
                                //                         int deleteTweet1Int = int.Parse(deleteTweet1);
                                //                         tweetDictionary.Remove(deleteTweet1Int);
                                //                         Console.WriteLine($"Tweet with Number {deleteTweet1Int} has been deleted");

                                //                         Console.WriteLine();
                                //                         Console.WriteLine("Enter 'C' to continue or 'k' to go back to Zana's Main Menu");
                                //                         string afterDeletingTweetContinue = Console.ReadLine().ToUpper();
                                //                         switch (afterDeletingTweetContinue)
                                //                         {
                                //                             case "C":

                                //                                 // I used foreach loop to show user's each remaining Tweet; you can also use a forloop only if you want to
                                //                                 Console.WriteLine($"{userName}, There are no more Tweets, Enter 'M' to go back to Main Menu, or Enter 'Q' to Quit Application");
                                //                                 string afterUserDeletesTweet = Console.ReadLine().ToUpper();

                                //                                 switch (afterUserDeletesTweet)
                                //                                 {
                                //                                     case "M":
                                //                                         Main();
                                //                                         break;

                                //                                     case "Q":
                                //                                         Console.WriteLine($"Goodbye {userName}");
                                //                                         break;

                                //                                     default:
                                //                                         Console.WriteLine($"Dear {userName} Zana didn't get that, Please Try again");
                                //                                         Main();
                                //                                         break;
                                //                                 }

                                //                                 // Console.WriteLine("Would you like to Delete another Tweet?");
                                //                                 // Console.WriteLine("Enter 'Y' for a Yes and 'N' for a No");

                                //                                 // string afterDeletingTweetContinue2 = Console.ReadLine();

                                //                                 // switch (afterDeletingTweetContinue2)
                                //                                 // {
                                //                                 //     case "Y":
                                //                                 //         Console.WriteLine("Input the Tweet Number you would like to delete");
                                //                                 //         string deleteTweet2 = Console.ReadLine();
                                //                                 //         int deleteTweet2Int = int.Parse(deleteTweet2);
                                //                                 //         tweetDictionary.Remove(deleteTweet2Int);
                                //                                 //         break;

                                //                                 //     default:
                                //                                 //     break;
                                //                                 // }

                                //                                 break;
                                //                             case "K":
                                //                                 Console.WriteLine("Going to the Main Menu..........");
                                //                                 Main();
                                //                                 break;

                                //                             default:
                                //                                 Console.WriteLine($"Dear {userName} Zana didn't get that, Please Try again");
                                //                                 Main();
                                //                                 break;
                                //                         }
                                //                         break;

                                //                     case 4:
                                //                         Console.WriteLine();
                                //                         Console.WriteLine();
                                //                         Console.WriteLine("Here are all your Tweets");
                                //                         foreach (KeyValuePair<int, string> eachRemainingTweet in tweetDictionary)
                                //                         {
                                //                             Console.WriteLine($"You added the Tweet: '{eachRemainingTweet.Value}', Zana says it was your number {eachRemainingTweet.Key} Tweet");

                                //                         }

                                //                         break;
                                //                     default:

                                //                         Console.WriteLine($"Dear {userName} Zana didn't get that, Please Try again");
                                //                         Main();
                                //                         break;

                                //                 }
                                //                 break;
                                //             case "K":
                                //                 // When user inputs K, that tells Zana to quit the Application ASAP
                                //                 Console.WriteLine($"Goodbye {userName}");
                                //                 break;



                                //             default:
                                //                 // The default;when we input a value Zana wasn;t expecting and then we make Zana restart our app for us

                                //                 Console.WriteLine($"Dear {userName} Zana didn't get that, Please Try again");
                                //                 Main();
                                //                 break;
                                //         }


                                //         break;




                                //     default:
                                //         // when user inputs a value that Zana cannot understand, I tell Zana to take my User to the case "Y" which is a parent case to this present switch-statement(userContinue)

                                //         Console.WriteLine($"Dear {userName} Zana didn't get that, Please Try again");
                                //         Main();
                                //         break;
                                // }
                                // break;

                                //     // break;
                                //     case "N":
                                //         Console.WriteLine("Goodbye My Dear User");
                                // break;
                                // default:

                                //         Console.WriteLine("Dear User Zana didn't get that, Please Try again");
                                // Main();
                                // break;
                                // }


                        }
                        break;
                }
                break;
        }
    }
}
*/