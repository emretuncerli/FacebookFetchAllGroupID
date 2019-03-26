using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Net;
using System.IO;
using System.Text;
using System.Collections;

namespace FacebookUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getPageTitleUrlAndPagrSource()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com");
            driver.FindElement(By.Id("email")).SendKeys("aa@hotmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("aaa");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("u_0_2")).Click();
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://www.facebook.com/groups");
            Thread.Sleep(420000);

            IWebElement bodyElement = driver.FindElement(By.Id("group-discover-card-left-columnmembership"));
            ReadOnlyCollection<IWebElement> divElements = bodyElement.FindElements(By.TagName("li"));
            foreach (var item in divElements)
            {
                Console.WriteLine(item.GetAttribute("id"));
            }
            driver.Close();


        }


    }
}
