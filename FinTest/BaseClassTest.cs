using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FinTest
{
	public class BaseClass
	{
        public static IWebDriver myDriver;

        public static void SeleniumOpn()
        {
            myDriver = new ChromeDriver();
            myDriver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }

        public static void SeleniumClose()
        {
            myDriver.Quit();
        }
        public static void SeleniumWrite(By by, string value)
        {
            myDriver.FindElement(by).SendKeys(value);
        }
        public static void SeleniumClick(By by)
        {
            myDriver.FindElement(by).Click();
        }
        
        
    
    }
}

