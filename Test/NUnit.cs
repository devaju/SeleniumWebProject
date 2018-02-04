using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test
{
    class NUnit
    {
        IWebDriver driver;

        [SetUp]
        public void InitializeBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestNunit()
        {
            driver.Navigate().GoToUrl("https://worldofwarcraft.com/en-us/");
            driver.Manage().Window.Maximize();

            IWebElement testing = driver.FindElement(By.XPath("Logo"));
            IWebElement testing = driver.FindElement()
            Assert.IsTrue(testing.Displayed);

        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
        
    }
}
