﻿using MyCodeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            //string value = myScrape.ScrapeWebpage("http://msdn.microsoft.com");
            string value = myScrape.ScrapeWebpage("http://msdn.microsoft.com", @"c:\users\public\testfolder\html2.txt");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
