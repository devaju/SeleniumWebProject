using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver webdriver = new ChromeDriver();
            webdriver.Navigate().GoToUrl("https://www.google.com");
        }
    }
}
