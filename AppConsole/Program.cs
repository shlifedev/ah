using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
namespace AppConsole
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            IWebDriver driver = new ChromeDriver(); 
            driver.Navigate().GoToUrl("https://sell.smartstore.naver.com/#/products/create"); 
        }
    }
}
