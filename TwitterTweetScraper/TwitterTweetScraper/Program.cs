﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

// Objective: Scrape all available tweets from 
// a user's profile on Twitter.com
// This ability is limited by the Twitter API
// so it will be impossible to scrape ALL
// tweets before a specific date

namespace TwitterTweetScraper
{    

    class Program
    {
        static void Main(string[] args)
        {            
            Greeting();
            Console.ReadKey();
        }        

        static void Greeting()
        {            
            Console.WriteLine("Welcome to the Twitter Tweet Scraper!");
            UserCredentialAuthentication();
            string userName = UserNameToFind();
            int numberOfTweets = NumberOfTweetsToScrape();
            TweetScraper(userName, numberOfTweets);
        }

        // This is the only section you should really need to edit
        // in order to get this to work
        // You need to go to https://apps.twitter.com/ to 
        // register for your consumerKey, consumerSecret,
        // accessToken, and accessTokenSecret
        // Once done just copy/paste the info there and you
        // should be able to run this!

        static void UserCredentialAuthentication()
        {
            string consumerKey = ""; // Looks like: e2zthFO1884yui3qwea8mklpo7
            string consumerSecret = ""; // Looks like: qawsBi6o8HhIslB4DDyxI7VDLW4MbEPcGANQ1zcPOMyYUKWEw
            string accessToken = ""; // Looks like: 1847523685-i3lO4J5mkGrRxxIIkTotRg9Spfqd4Gyu357rQv4
            string accessTokenSecret = ""; // Looks like: CatC8CnXQ3hNWwKhov4kOyjgADellESPCieS0A7kLJHjx

            Auth.SetUserCredentials(consumerKey, consumerSecret, accessToken, accessTokenSecret);
        }

        static string UserNameToFind()
        {
            Console.WriteLine("Please enter the user's Twitter name to get their tweets: ");
            string userNameToFind = Console.ReadLine();            
            return userNameToFind;

        }

        static int NumberOfTweetsToScrape()
        {
            int numberOfTweetsToScrape = 0;

            Console.WriteLine("Enter the number of tweets to scrape (between 1 - 3200): ");
            string numberOfTweetsToScrapeEntered = Console.ReadLine();
            numberOfTweetsToScrape = Convert.ToInt32(numberOfTweetsToScrapeEntered);
            return numberOfTweetsToScrape;
        }

        static void TweetScraper(string userNameToFind, int numberOfTweetsToScrape)
        {

            string userName = userNameToFind;
            int numberOfTweets = numberOfTweetsToScrape;

            RateLimit.RateLimitTrackerMode = RateLimitTrackerMode.TrackAndAwait;
            RateLimit.QueryAwaitingForRateLimit += (sender, args) =>
            {
                Console.WriteLine($"Query : {args.Query} is awaiting for rate limits!");
            };

            var allTweets = Timeline.GetUserTimeline(userName, numberOfTweetsToScrape).ToArray();
            using (StreamWriter writer = new StreamWriter("H:\\" + userName + " Tweets.txt", true))
            {
                foreach (var tweets in allTweets)
                {
                    Console.WriteLine(tweets);
                    writer.WriteLine(tweets);
                }
            }
        }
      
    }
}