using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

// Objective: Scrape the Titles of the latest Manga
// at mangahere.co/latest
// Example Target: http://www.mangahere.co/latest/

namespace LittleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting();
            string targetUrl = UrlToScrape();
            ConnectToSite(targetUrl);
            Console.ReadKey();

        }

        static void Greeting()
        {
            Console.WriteLine("Hello and welcome to the Little Web Scraper!");
            Console.WriteLine();
        }

        static string UrlToScrape()
        {
            Console.WriteLine("Please enter the url you would like to scrape: ");
            string urlToScrape = Console.ReadLine();
            return urlToScrape;
        }

        static void ConnectToSite(string urlToScrape)
        {
            HtmlDocument doc = new HtmlWeb().Load(urlToScrape);
            ScrapeData(doc);
        }

        static void ScrapeData(HtmlDocument doc)
        {
            
            var mangaTitles = doc.DocumentNode.SelectNodes("//a[@class='manga_info']").ToList();

            foreach (var mangaTitle in mangaTitles)
            {
                Console.WriteLine(mangaTitle.InnerText);
            }
        }
    }
}
