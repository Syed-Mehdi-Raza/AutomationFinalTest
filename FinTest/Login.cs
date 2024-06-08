using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FinTest
{
	public class Login : BaseClass
	{ 
        public void Signin()
		{
            By UserName = By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[1]/div/div[2]/input");
            By PassWord = By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[2]/div/div[2]/input");
            By LoginBtn = By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button");
            Thread.Sleep(5000);
				SeleniumWrite(UserName, "Admin");
				SeleniumWrite(PassWord, "admin123");
			    SeleniumClick(LoginBtn);

		}

		
	}
}

