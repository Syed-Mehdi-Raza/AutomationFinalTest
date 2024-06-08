using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FinTest
{
    public class InvalidLogin : BaseClass
    {
        public void SignFa()
        {
            By UserName = By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[1]/div/div[2]/input");
            By PassWord = By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[2]/div/div[2]/input");
            By LoginBtn = By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button");
            Thread.Sleep(5000);
            SeleniumWrite(UserName, "xyz");
            SeleniumWrite(PassWord, "123Zyjs");
            SeleniumClick(LoginBtn);

        }


    }
}

