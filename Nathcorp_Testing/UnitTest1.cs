using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace Nathcorp_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TC_01()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#home")).Click();
            driver.Close();
            TC_02();
        }
        public void TC_02()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#about")).Click();
            driver.Close();
            TC_03();
        }
        public void TC_03()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#Services")).Click();
            //driver.Navigate().Back();
            driver.Close();
            TC_04();
        }
        public void TC_04()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#News")).Click();
            driver.Close();
            TC_05();
        }
        public void TC_05()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#partner")).Click();
            driver.Close();
            TC_06();

        }
        public void TC_06()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#contacts")).Click();
            driver.Close();

        }
        public void TC_07()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.XPath("//*[@id='myCarousel']/a[2]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='myCarousel']/a[2]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='myCarousel']/a[2]")).Click();
            Thread.Sleep(1000);
            driver.Close();
            TC_08();
        }
        public void TC_08()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#content > div:nth-child(1) > div > div > div > ul > li:nth-child(1) > a")).Click();
            driver.Close();
            TC_09();
        }
        public void TC_09()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#content > div:nth-child(1) > div > div > div > ul > li:nth-child(2) > a")).Click();
            driver.Close();
            TC_10();
        }
        public void TC_10()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#content > div:nth-child(1) > div > div > div > ul > li:nth-child(3) > a")).Click();
            driver.Close();
            TC_011();
        }
        public void TC_011()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#content > div:nth-child(1) > div > div > div > ul > li:nth-child(4) > a")).Click();
            driver.Close();
            TC_012();
        }
        public void TC_012()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#content > div:nth-child(1) > div > div > div > ul > li:nth-child(5) > a")).Click();
            driver.Close();
            TC_013();
        }
        public void TC_013()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#content > div:nth-child(1) > div > div > div > ul > li:nth-child(6) > a")).Click();
            driver.Close();
            TC_014();
        }
        public void TC_014()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#content > div:nth-child(1) > div > div > div > ul > li:nth-child(7) > a")).Click();
            driver.Close();
            TC_015();
        }
        public void TC_015()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#MainContent_Nathcorp_solutions > li:nth-child(1) > a")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#MainContent_Nathcorp_solutions > li:nth-child(2) > a")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#MainContent_Nathcorp_solutions > li:nth-child(3) > a")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#MainContent_Nathcorp_solutions > li:nth-child(4) > a ")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#MainContent_Nathcorp_solutions > li:nth-child(5) > a")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#MainContent_Nathcorp_solutions > li:nth-child(6) > a")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#MainContent_Nathcorp_solutions > li:nth-child(7) > a")).Click();
            driver.Navigate().Back();
            driver.Close();
            TC_016();
        }
        public void TC_016()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#Services")).Click();
            driver.FindElement(By.CssSelector("#content > article > div > div > div > div:nth-child(6) > a:nth-child(1) > div > div > img")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#content > article > div > div > div > div:nth-child(6) > a:nth-child(2) > div > div > img")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#content > article > div > div > div > div:nth-child(6) > a:nth-child(3) > div > div > img")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#content > article > div > div > div > div:nth-child(7) > a:nth-child(1) > div > div > img")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#content > article > div > div > div > div:nth-child(7) > a:nth-child(2) > div > div > img")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#content > article > div > div > div > div:nth-child(7) > a:nth-child(3) > div > div > img")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#content > article > div > div > div > div:nth-child(8) > a > div > div > img")).Click();
            driver.Close();
            TC_017();
        }
        public void TC_017()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#News")).Click();
            driver.FindElement(By.CssSelector("#main > div > div > div.col-md-8 > div > div.post-wrap > article:nth-child(1) > div.content > div.posts > div > a")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#main > div > div > div.col-md-8 > div > div.post-wrap > article:nth-child(2) > div.content > div.posts > div > a")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#main > div > div > div.col-md-8 > div > div.post-wrap > article:nth-child(3) > div.content > div.posts > div > a")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#main > div > div > div.col-md-8 > div > div.post-wrap > article:nth-child(4) > div.content > div.posts > div > a")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#main > div > div > div.col-md-8 > div > div.post-wrap > article:nth-child(5) > div.content > div.posts > div > a")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#main > div > div > div.col-md-8 > div > div.post-wrap > article:nth-child(6) > div.content > div.posts > div > a")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#main > div > div > div.col-md-8 > div > div.post-wrap > article:nth-child(7) > div.content > div.posts > div > a")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#main > div > div > div.col-md-8 > div > div.post-wrap > article:nth-child(8) > div.content > div.posts > div > a")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#main > div > div > div.col-md-8 > div > div.post-wrap > article:nth-child(9) > div.content > div.posts > div > a")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("#main > div > div > div.col-md-8 > div > div.post-wrap > article:nth-child(10) > div.content > div.posts > div > a")).Click();
            driver.Navigate().Back();
            driver.Close();
            TC_018();

        }
        public void TC_018()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.CssSelector("#img_logoBanner")).Click();
            driver.Close();
            TC_019();
        }
        public void TC_019()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.nathcorp.com/");
            driver.FindElement(By.ClassName("#elip1")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.ClassName("fa fa - facebook pulse")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("")).Click();
            driver.Navigate().Back();
            driver.FindElement(By.CssSelector("")).Click();
            driver.Navigate().Back();
            driver.Close();
        }


    }
}
